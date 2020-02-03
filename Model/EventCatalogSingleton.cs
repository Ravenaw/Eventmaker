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
        private EventCatalogSingleton _instance;
        private ObservableCollection<Event> EventCatalog;

        private EventCatalogSingleton()
        {
            EventCatalog=new ObservableCollection<Event>();
        }

        public EventCatalogSingleton Instance
        {
            get
            {
                if (EventCatalog != null)
                {
                    return _instance;
                }
                else
                {
                    _instance=new EventCatalogSingleton();
                    return _instance;
                }
            }
        }

        public void Add(Event e)
        {
            EventCatalog.Add(e);
        }
    }
}
