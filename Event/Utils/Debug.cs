using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event.Utils
{
    public class Debug
    {
        public static bool IsDebugMode { get; set; }

        public static void Log(object obj)
        {
            if (IsDebugMode) Console.WriteLine(obj.ToString());
        }
    }
}
