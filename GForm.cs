using Google.Apis.Drive.v3;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Logger;
using static Launcher.Program;


namespace Launcher
{    
    public partial class GForm : Form
    {      
        public GForm() {
            TopMost = true;
            InitializeComponent();
        }

        private void GForm_Load(object sender, EventArgs e)
        {             
            _startBtn = new StartButtonState(GButton_play);
            _settings = new GSettings();
            _news = new News(this);
            _news.Parse();

            _startBtn.SetState(StartButtonStates.Settings);
            if (_config.ArmaPath == null) _config.GetGamePath();
            if (_config.GamePathIsValid())
            {
                if (_config.ModPath == null) _config.GetModPath();
                _driveApi.StartModCheck();
            };
        }

        public void UpdateProgress(int value, string fileName)
        {
            GProgress.Value = value;
            GLabel_update.Text = fileName;
            GLabel_progress.Text = $"{value}%";
        }

        private void GButton_forum_Click(object sender, EventArgs e)
        {
            Navigation.GoToLink(sender);
        }

        private void GButton_settings_Click(object sender, EventArgs e)
        {
            Navigation.OpenSettingMenu();
        }

        private void GButton_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GButton_forum_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void GButton_lk_Click(object sender, EventArgs e)
        {
            Navigation.GoToLink(sender);
        }

        private void GButton_vk_Click(object sender, EventArgs e)
        {
            Navigation.GoToLink(sender);
        }

        private void GButton_youtube_Click(object sender, EventArgs e)
        {
            Navigation.GoToLink(sender);
        }

        private void GButton_lk_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_vk_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_youtube_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_settings_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_min_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_close_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GButton_play_MouseEnter(object sender, EventArgs e)
        {
            Navigation.PlaySoundBtnEnter();
        }

        private void GForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _config.Save();
        }
    }
}
