using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmaker.Model
{
    class EventCatalogSingleton
    {
        private ObservableCollection<Event> EventCatalog;

        EventCatalogSingleton()
        {
            
        }

        public void Add(Event e)
        {
            EventCatalog.Add(e);
        }
    }
}
