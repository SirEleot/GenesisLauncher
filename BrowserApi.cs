using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Launcher.Logger;
using static Launcher.Program;

namespace Launcher
{

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisibleAttribute(true)]
    public class BrowserApi
    {
        public BrowserApi(WebBrowser browser)
        {
            SetIE8KeyforWebBrowserControl();
        }

        public static void Call(string script, params object[] args)
        {
            _browser.Document.InvokeScript(script, args);
        }

        private void SetIE8KeyforWebBrowserControl()
        {
            RegistryKey registryKey = null;
            string name = "Genesisrp.exe";
            try
            {
                registryKey = !Environment.Is64BitOperatingSystem ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Internet Explorer\\\\Main\\\\FeatureControl\\\\FEATURE_BROWSER_EMULATION", true) : Registry.LocalMachine.OpenSubKey("SOFTWARE\\\\Wow6432Node\\\\Microsoft\\\\Internet Explorer\\\\MAIN\\\\FeatureControl\\\\FEATURE_BROWSER_EMULATION", true);
                if (registryKey == null)
                {
                    LogIt("Application Settings Failed - Address Not found");
                }
                else
                {
                    string str1 = Convert.ToString(registryKey.GetValue(name));
                    if (str1 == "10000")
                    {
                        registryKey.Close();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(str1))
                            registryKey.SetValue(name, (object)10000, RegistryValueKind.DWord);
                        string str2 = Convert.ToString(registryKey.GetValue(name));
                        if (!(str2 != "10000"))
                            return;
                        LogIt("Application Settings Failed, Ref: " + str2);
                    }
                }
            }
            catch (Exception ex)
            {
                LogIt("Application Settings Failed");
                LogIt(ex.Message);
            }
            finally
            {
                registryKey?.Close();
            }
        }
    }
}
