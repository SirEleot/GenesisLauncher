using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using static Launcher.Program;

namespace Launcher
{
    class DriveApi
    {
        DriveService _service;
        IList<Google.Apis.Drive.v3.Data.File> _remoteFileList;
        IList<Google.Apis.Drive.v3.Data.File> _remoteKeyList;

        private string[] Scopes { get;} = new string[1]
        {
            DriveService.Scope.DriveReadonly
        };
        private string AppName { get; set; } = "Drive API .NET Quickstart";
        public object Systems { get; private set; }

        public DriveApi(Config config)
        {
            _config = config;
            UserCredential Result;
            using( FileStream s = new FileStream(@"credentials.json", FileMode.Open, FileAccess.Read))
            {
                string Token = @"token";
                Result = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load((Stream)s).Secrets,
                    (IEnumerable<string>)Scopes, "user",
                    CancellationToken.None,
                    (IDataStore)new FileDataStore(Token, true),
                    (ICodeReceiver) null).Result;
            }
            _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = (IConfigurableHttpClientInitializer)Result,
                ApplicationName = AppName
            });

            _remoteFileList =  GetFileList();
            _remoteKeyList = GetFileList(true);
        }

        public async void BeginModUpdate_async()
        {            
            var progress = new Progress<int>(v => {
                if (v > 99)
                {
                    _startBtn.SetState(StartButtonStates.Play);
                    _progressBar.Value = 100;
                }else _progressBar.Value = v;

            });
            _progressBar.Value = await Task.Factory.StartNew<int>(() => ProgressUpdate(progress));
        }
        
        private int ProgressUpdate( IProgress<int> progress)
        {
            int Total = _remoteFileList.Count;
            int Complited = 0;
            foreach (Google.Apis.Drive.v3.Data.File file in _remoteFileList)
            {
                string FullFileName = _config.ModPath + @"\" + file.Name;
                if (System.IO.File.Exists(FullFileName))
                {
                    if (file.ModifiedTime.Value != System.IO.File.GetLastWriteTime(FullFileName)) {                        
                        System.IO.File.Delete(FullFileName);
                        DownloadFile(file, FullFileName);
                    }
                }
                else DownloadFile(file, FullFileName);
                Complited++;
                progress.Report(100/Total*Complited);
            }
            
            return 100;
        }

        private void DownloadFile(Google.Apis.Drive.v3.Data.File file, string path, bool needKey = true)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                FilesResource.GetRequest request = _service.Files.Get(file.Id);
                request.MediaDownloader.ProgressChanged += (Action<IDownloadProgress>)(p =>
                {
                    switch (p.Status)
                    {
                        case DownloadStatus.NotStarted:
                            Logger.LogIt($"Ошибка загрузки файла {file.Name}  #1");
                            break;
                        case DownloadStatus.Downloading:
                            Logger.LogIt($"Загружается файл: {file.Name}");
                            break;
                        case DownloadStatus.Completed:
                            SaveStream(ms, path, file.ModifiedTime.Value);
                            break;
                        case DownloadStatus.Failed:
                            Logger.LogIt($"Ошибка загрузки файла {file.Name}  #2");
                            break;
                        default:
                            break;
                    }
                });
                request.Download((Stream)ms);
            }
            if (needKey)
            {               
                Google.Apis.Drive.v3.Data.File key = _remoteKeyList.FirstOrDefault(f => f.Name == file.Name + "." + _config.KeyName + ".bisign");
                if (key != null)
                {
                    string FullKeyName = _config.ModPath + @"\" + file.Name + "." + _config.KeyName + ".bisign";
                    if (System.IO.File.Exists(FullKeyName)) System.IO.File.Delete(FullKeyName);
                    DownloadFile(key, FullKeyName, false);
                }
                else Logger.LogIt($"Ключ {file.Name + "." + _config.KeyName + ".bisign"}  для файла {file.Name} не обнаружен");
            }            
        } 

        private void SaveStream(MemoryStream stream, string saveTo, DateTime rTime)
        {
            using (FileStream fileStream = new FileStream(saveTo, FileMode.Create, FileAccess.Write))
                stream.WriteTo((Stream)fileStream);
            System.IO.File.SetLastWriteTime(saveTo, rTime);
        }

        private IList<Google.Apis.Drive.v3.Data.File> GetFileList(bool isKey = false)
        {
            FilesResource.ListRequest listRequest = _service.Files.List();
            listRequest.PageSize = new int?(460);
            listRequest.Fields = "nextPageToken , files(id, name, parents, size, modifiedTime)";
            listRequest.Q = isKey ? "name contains '.bisign' and trashed = false" : "not name contains '.bisign' and trashed = false";  
            return listRequest.Execute().Files;
        }
        public void StartModCheck()
        {
            _startBtn.SetState(StartButtonStates.BeginUpdate);
            if (_config.ModPath == null || _config.ModPath == _config.ArmaPath)
            {
                _startBtn.SetState(StartButtonStates.Settings);
                MessageBox.Show("Неверно указана папка для установки мода.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                if (Directory.Exists(_config.ModPath))
                {
                    if (Directory.GetFiles(_config.ModPath).Length > 0) BeginModUpdate_async();
                    else if (MessageBox.Show("Эта папка пуста. Желаете в нее установить мод?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes) BeginModUpdate_async();
                    else _startBtn.SetState(StartButtonStates.Update);
                }
                else _config.GetModPath();
            }

        }
    }
    
}
