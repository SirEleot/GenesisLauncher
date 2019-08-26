using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        public static GForm _form;
        public static DriveApi _driveApi;
        public static Config _config;
        public static StartButtonState _startBtn;
        public static GSettings _settings;
        public static SoundPlayer _mediaplayer = new SoundPlayer();
        public static News _news;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _config = Config.Get();
            _driveApi = new DriveApi();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _form = new GForm();
            Application.Run(_form);
        }

    }
}
