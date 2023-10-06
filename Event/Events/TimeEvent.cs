using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event.Events
{
    public class TimeEvent : IEvent
    {
        private long time;
        public TimeEvent() : base("TimeEvent", false, false) { }

        public TimeEvent(long time) : this()
        {
            this.time = time;
        }

        public long GetTime()
        {
            return time;
        }
    }
}
