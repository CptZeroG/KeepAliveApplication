using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Configuration;

namespace KeepRunApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileexetokeepalive = ConfigurationManager.AppSettings["AppToKeepAlive"];
            if (fileexetokeepalive.ToLower().EndsWith("exe"))
            {
                var runningProcessByName = Process.GetProcessesByName(fileexetokeepalive.Replace(".exe",""));
                if (runningProcessByName.Length == 0)
                {
                    Process.Start(fileexetokeepalive);
                }
            }
            else
            {
                throw new Exception("Must be set a correct app in the config file (only EXE file is supported)");
            }
        }
    }
}
