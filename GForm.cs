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
            InitializeComponent();
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void GForm_Load(object sender, EventArgs e)
        {  
            GBrowser.ObjectForScripting = new BrowserApi(GBrowser);
            GBrowser.Navigate(_config.Interface ?? "http://www.newgenesis.ru/LInterface/launcher.html");
            _browser = GBrowser;
            _browser.Refresh(WebBrowserRefreshOption.Completely);
            _browser.WebBrowserShortcutsEnabled = false;
            _startBtn = new StartButtonState(GButton_play);
            _progressBar = GProgress;
            _settings = new GSettings();            

            _startBtn.SetState(StartButtonStates.Settings);
            if (_config.ArmaPath == null) _config.GetGamePath();
            if (_config.GamePathIsValid())
            {
                if (_config.ModPath == null) _config.GetModPath();
                _driveApi.StartModCheck();
            };
        }

    }
}
