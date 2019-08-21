using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        public static DriveApi _driveApi;
        public static Config _config;
        public static WebBrowser _browser;
        public static StartButtonState _startBtn;
        public static ProgressBar _progressBar;
        public static GSettings _settings;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _config = Config.Get();
            _driveApi = new DriveApi(_config);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GForm());
        }

    }
}
