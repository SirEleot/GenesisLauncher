using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public static class Logger
    {
        public static void LogIt(string log)
        {
            if (!Directory.Exists("Logs")) Directory.CreateDirectory("Logs");
            using (StreamWriter w = new StreamWriter($"Logs\\{DateTime.Now.ToString("dd.MM.yyyy")}_.log", true, Encoding.UTF8))
            {
                w.WriteLine($"{DateTime.Now.ToString("HH.mm.ss")}: {log}");
            }
        }
    }
}
