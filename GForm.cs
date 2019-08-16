using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Launcher
{    
    public partial class GForm : Form
    {
        DriveApi _driveApi;
        public GForm() {
            InitializeComponent();
            _driveApi = new DriveApi();
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            Browser.ObjectForScripting = new BrowserApi(Browser);
            Browser.Navigate("http://www.newgenesis.ru/LInterface/launcher.html");
        }

        private void GForm_Load(object sender, EventArgs e)
        {
        }
    }
}
