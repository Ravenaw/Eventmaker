using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Eventmaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance;
        public ObservableCollection<Event> EventCatalog { get; set; }

        private EventCatalogSingleton()
        {
            EventCatalog = new ObservableCollection<Event>
            {
                new Event(1,"event1","*","somewhere",DateTime.Now),
                new Event(2,"event2","*","other place",DateTime.Now)
            };
        }

        public static EventCatalogSingleton Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                else
                {
                    _instance = new EventCatalogSingleton();
                    return _instance;
                }
            }
        }

        public void Add(Event e)
        {
            EventCatalog.Add(e);
        }

        public void Remove(int i)
        {
            EventCatalog.RemoveAt(i);
        }
    }
}
