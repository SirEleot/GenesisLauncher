using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Log
    {
        public static void File(string log)
        {
            using(StreamWriter w = new StreamWriter("Log.txt"))
            {
                w.WriteLine(log);
            }
        }
    }
}
