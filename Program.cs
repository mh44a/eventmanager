using EventManager.Event.Events;
using EventManager.Event.Listener;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            Event.Utils.Debug.IsDebugMode = false; // TODO: for debugging logs.
          
            Event.EventManager.RegisterListener(new GlobalListener());

            while (true)
            {
                string option = Console.ReadLine();
                Console.WriteLine("Your option: " + option);
                if (option == "time")
                {
                    Event.EventManager.CallEvent(new TimeEvent(DateTime.UtcNow.Ticks));
                }
            }
        }
    }
}
