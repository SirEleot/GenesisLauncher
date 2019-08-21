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

        public void SetGamePath(string path)
        {
            GTbox_gamePath.Text = path;
        }
        public void SetModPath(string path)
        {
            GTbox_modPath.Text = path;
        }
    }
}
