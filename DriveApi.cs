using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Launcher
{
    class DriveApi
    {
        DriveService _service;
        private string[] Scopes { get;} = new string[1]
        {
            DriveService.Scope.DriveReadonly
        };
        private string AppName { get; set; } = "Drive API .NET Quickstart";
        public object Systems { get; private set; }

        public DriveApi()
        {
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
        }

        public void CheckDrive()
        {
            FilesResource.ListRequest listRequest = _service.Files.List(); listRequest.PageSize = new int?(460);
            listRequest.PageSize = new int?(460);
            listRequest.Fields = "nextPageToken , files(id, name, parents, size, modifiedTime)";
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
            Log.File(files.Count.ToString());
        }
    }
}
