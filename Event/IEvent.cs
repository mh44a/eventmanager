using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event
{
    public abstract class IEvent
    {
        public string eventName;
        public bool async;
        public bool cancelled;

        public IEvent(string name, bool async, bool cancelled)
        {
            this.eventName = name;
            this.async = async;
            this.cancelled = cancelled;
        }

        public IEvent() : this("DefaultEvent", false, false) { }
        public IEvent(string name) : this(name, false, false) { }
        public IEvent(string name, bool async) : this(name, async, false) { }

        public string GetEventName()
        {
            return eventName;
        }

        public bool IsAsync()
        {
            return async;
        }

        public IEvent GetEvent()
        {
            return this;
        }

        public bool IsCancelled()
        {
            return cancelled;
        }
    }
}
