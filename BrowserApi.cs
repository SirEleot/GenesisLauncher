using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisibleAttribute(true)]
    public class BrowserApi
    {
        WebBrowser _browser;
        public BrowserApi(WebBrowser browser)
        {
            _browser = browser;
        }

        public void CheckBrowserApi()
        {
            _browser.Url = new Uri("https://2ip.ru/");
        }
    }
}
