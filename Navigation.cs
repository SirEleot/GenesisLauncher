using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Program;

namespace Launcher
{
    class Navigation
    {
        public static void GoToLink(object sender)
        {
            Button Btn = (Button)sender;
            int index = Convert.ToInt32(Btn.Tag);
            Process.Start(_config.Links[index]);
        }

        public static void OpenSettingMenu()
        {
            _settings.UpdateSettingsMenu();
            _settings.ShowDialog();
        }

        public static void PlaySoundBtnEnter()
        {
            _mediaplayer.Stream = Properties.Resources.Windows_Navigation_Start;
            _mediaplayer.PlaySync();
        }
    }
}
