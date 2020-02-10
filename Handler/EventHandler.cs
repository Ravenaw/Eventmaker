using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Eventmaker.Converter;
using Eventmaker.Model;
using Eventmaker.View;
using Eventmaker.ViewModel;

namespace Eventmaker.Handler
{
    class EventHandler
    {
        public EventViewModel Handler { get; set; }

        public EventHandler(EventViewModel evm)
        {
            Handler = evm;
        }

        public void CreateEvent()
        {
            Event e = new Event(Handler.ID, Handler.Name, Handler.Description, Handler.Place, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(Handler.Date, Handler.Time));
            Handler.Instance.Add(e);
        }

        public void DeleteEvent()
        {
            Handler.Instance.Remove(Handler.SelectedEventIndex);
        }
    }
}
