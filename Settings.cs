using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Program;

namespace Launcher
{
    public partial class GSettings : Form
    {
        public GSettings()
        {
            TopMost = true;
            InitializeComponent();
        }

        private void GButton_settingGamePath_Click(object sender, EventArgs e)
        {
            _config.GetGamePath();            
        }

        private void GButton_settingModPath_Click(object sender, EventArgs e)
        {
            _config.GetModPath();
        }

        public void UpdateSettingsMenu()
        {
            GTbox_gamePath.Text = _config.ArmaPath;
            GTbox_modPath.Text = _config.ModPath;
            GCheck_HT.Checked = _config.HyperThreading;
            GCheck_window.Checked = _config.Window;
            GCheck_x64.Checked = _config.x64;          
        }

        private void GCheck_x64_CheckedChanged(object sender, EventArgs e)
        {
            _config.x64 = (sender as CheckBox).Checked;
        }

        private void GCheck_window_CheckedChanged(object sender, EventArgs e)
        {
            _config.Window = (sender as CheckBox).Checked;
        }

        private void GCheck_HT_CheckedChanged(object sender, EventArgs e)
        {
            _config.HyperThreading = (sender as CheckBox).Checked;
        }

        private void GSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            _config.Save();
        }
    }
}
