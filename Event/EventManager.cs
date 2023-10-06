using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event
{
    public class EventManager
    {
        private static List<EventListener> eventListeners = new List<EventListener>();

        public static void RegisterListener(EventListener listener)
        {
            if (eventListeners.Contains(listener)) return;
            eventListeners.Add(listener);
            Event.Utils.Debug.Log("Listener registered. (" + listener.GetType().Name + ")");
        }

        public static void UnregisterListener(EventListener listener)
        {
            if (!eventListeners.Contains(listener)) return;
            eventListeners.Remove(listener);
            Event.Utils.Debug.Log("Listener unregistered. (" + listener.GetType().Name + ")");
        }

        public static void CallEvent(IEvent @event)
        {
            foreach (EventListener listeners in eventListeners)
            {
                var allMethods = listeners.GetType().GetMethods().Where(m => m.GetCustomAttributes(typeof(EventHandler), false).Length > 0).ToArray();
                if (allMethods == null)
                {
                    Event.Utils.Debug.Log("Event not registered.");
                    return;
                }

                foreach (var m in allMethods)
                {
                    foreach (ParameterInfo parameterInfo in m.GetParameters())
                    {
                        bool containsEvent = (parameterInfo.ParameterType.Name.Equals(@event.GetEventName()));
                        if (!containsEvent) continue;

                        object classInstance = Activator.CreateInstance(listeners.GetType());
                        m.Invoke(classInstance, new object[] { @event });
                    }
                }
            }
        }

    }
}
