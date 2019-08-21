using System;
using System.Collections.Generic;
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
                    Navigation.OpenSettingMenu(null, null);
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
           
        }

        private void SetButtonSettings()
        {
            string Text;
            switch (_currentState)
            {
                case StartButtonStates.Settings:
                    Text = "Настройки";
                    Enabled = true;
                    break;
                case StartButtonStates.Update:
                    Text = "Обновить";
                    Enabled = true;
                    break;
                case StartButtonStates.Play:
                    Text = "Играть";
                    Enabled = true;
                    break;
                case StartButtonStates.DontAvailable:
                    Text = "Сервер не доступен";
                    Enabled = false;
                    break;
                case StartButtonStates.BeginUpdate:
                    Text = "Идет обновление";
                    Enabled = false;
                    break;
                default:
                    Text = "Сервер не доступен";
                    Enabled = false;
                    break;
            }
            _button.Text = Text;
        }

        public void SetState(StartButtonStates state)
        {
            _currentState = state;
            SetButtonSettings();
        }

    }
}
