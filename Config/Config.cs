using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Program;

namespace Launcher
{
    public class Config
    {
        public string ArmaPath { get; set; }
        public string ArmaExeName { get; set; }
        public string ModPath { get; set; }
        public string Interface { get; set; }
        public List<string> Links { get; set; }
        public string KeyName { get; set; }

        public static Config Get()
        {
            using(StreamReader r = new StreamReader("Config.json"))
             {
                 return JsonConvert.DeserializeObject<Config>(r.ReadToEnd());
             }
        }

        private void SetArmaPath(string path)
        {
            ArmaPath = path;
            Save();
        }
        private void SetModPath(string path)
        {
            ModPath = path;
            Save();
        }
        private void Save()
        {
            using (StreamWriter w = new StreamWriter("Config.json"))
            {
                w.Write(JsonConvert.SerializeObject(this));
            }
        }

        public bool GamePathIsValid()
        {
            return File.Exists(ArmaPath + @"\" + ArmaExeName);
        }
        public void GetGamePath()
        {
            using (FolderBrowserDialog dg = new FolderBrowserDialog())
            {
                string str = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam").GetValue("SteamPath").ToString().Replace('/', '\\');
                if (File.Exists(str + @"\steamapps\common\Arma 3\" + ArmaExeName)) dg.SelectedPath = str + @"\steamapps\common\Arma 3\";
                dg.Description = "Укажите путь до папки с Arma3";
                dg.ShowNewFolderButton = false;
                if (Directory.Exists(ArmaPath)) dg.SelectedPath = ArmaPath;
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    if (GamePathIsValid())
                    {
                        SetArmaPath(dg.SelectedPath);
                        if (Directory.Exists(ModPath) && ModPath != ArmaPath) _startBtn.SetState(StartButtonStates.Update);
                    }
                    else SetArmaPath(ArmaPath);

                }
                else SetArmaPath(ArmaPath);
            }
            _settings.SetGamePath(_config.ArmaPath);
        }
        public void GetModPath()
        {
            using (FolderBrowserDialog dg = new FolderBrowserDialog())
            {
                dg.Description = "Укажите путь до папки с модом genesis";
                if (ModPath ==null && Directory.Exists(ArmaPath)) dg.SelectedPath = ArmaPath;
                else if (Directory.Exists(_config.ModPath)) dg.SelectedPath = ModPath;
                dg.ShowNewFolderButton = true;
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    if (ArmaPath == dg.SelectedPath)
                    {
                        MessageBox.Show("Невозможно установить мод в одну папку с игрой. Выберите другую папку.", "Внимание", MessageBoxButtons.OK);
                        SetModPath(_config.ModPath);
                    }
                    SetModPath(dg.SelectedPath);
                    if (GamePathIsValid()) _startBtn.SetState(StartButtonStates.Update);
                }
                else SetModPath(_config.ModPath);
            }
            _settings.SetModPath(_config.ModPath);
        }

    }
}
