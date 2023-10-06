using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Event
{
    [AttributeUsage(AttributeTargets.Method)]
    public class EventHandler : Attribute
    {
    }
}
