using EventManager.Event.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event.Listener
{
    public class GlobalListener : EventListener
    {
        [EventHandler]
        public void OnTime(TimeEvent @event)
        {
            Console.WriteLine("Current ms: " + new DateTime(@event.GetTime()).ToLocalTime());
        }
    }
}
