using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Program;

namespace Launcher
{
    enum StartButtonStates
    {
        Settings = 0,
        Update,
        Play,
        DontAvailable,
        BeginUpdate

    }
    class StartButtonState
    {
        private StartButtonStates _currentState;
        private Button _button;

        public bool Enabled { get { return _button.Enabled; } set { _button.Enabled = Enabled; } }
        public bool Visible { get { return _button.Visible; } set { _button.Visible = Visible; } }

        public StartButtonState(Button button)
        {
            _button = button;
            SetState(StartButtonStates.DontAvailable);
            _button.Click += OnClick;

        }

        public void OnClick(object sender, EventArgs e)
        {
            switch (_currentState)
            {
                case StartButtonStates.Settings:
                    Navigation.OpenSettingMenu();
                    break;
                case StartButtonStates.Update:
                    _driveApi.StartModCheck();
                    break;
                case StartButtonStates.Play:
                    StartGame();
                    break;
                case StartButtonStates.DontAvailable:
                    MessageBox.Show("Игровой сервер недоступен", "Внимание");
                    break;
                default:
                    break;
            }
        }

        private void StartGame()
        {
            string ExeFile = $"{_config.ArmaPath}\\{_config.BattlEyeExeName}";
            string StartParams = $"  -exe {(_config.x64 ? _config.ArmaExeName_x64 : _config.ArmaExeName)}" +
                $" -mod=\"{_config.ModPath}\" -noSplash -skipIntro" +
                $" -connect={_config.ServerIpAdress}" +
                $" -port={_config.ServerPort}" +
                $" -password=\"\"" +
                $" {(_config.HyperThreading ? "-enableHT" : "")}" +
                $" {(_config.Window ? "-window" : "")}";
            if (File.Exists(ExeFile))
            {
                Logger.LogIt(ExeFile + "\n" + StartParams);
                Process process = Process.Start(ExeFile, StartParams);
                Environment.Exit(0);
            }
        }

        private void SetButtonSettings()
        {
            System.Drawing.Bitmap Img;
            switch (_currentState)
            {
                case StartButtonStates.Settings:
                    Img =  Properties.Resources.settings;
                    Enabled = true;
                    break;
                case StartButtonStates.Update:
                    Img = Properties.Resources.update;
                    Enabled = true;
                    break;
                case StartButtonStates.Play:
                    Img = Properties.Resources.play_button;
                    Enabled = true;
                    break;
                case StartButtonStates.DontAvailable:
                    Img = Properties.Resources.servernotwork;
                    Enabled = false;
                    break;
                case StartButtonStates.BeginUpdate:
                    Img = Properties.Resources.servernotwork;
                    Enabled = false;
                    break;
                default:
                    Img = Properties.Resources.servernotwork;
                    Enabled = false;
                    break;
            }
            _button.Image = Img;
        }

        public void SetState(StartButtonStates state)
        {
            _currentState = state;
            SetButtonSettings();
        }

    }
}
