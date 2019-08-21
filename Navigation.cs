using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Program;

namespace Launcher
{
    class Navigation
    {
        public static void GoToLink(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            int index = Convert.ToInt32(Btn.Tag);
            Process.Start(_config.Links[index]);
        }

        public static void OpenSettingMenu(object sender, EventArgs e)
        {
            _settings.SetGamePath(_config.ArmaPath);
            _settings.SetModPath(_config.ModPath);
            _settings.ShowDialog();
        }
    }
}
