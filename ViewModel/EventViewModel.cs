using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventmaker.Model;

namespace Eventmaker.ViewModel
{
    class EventViewModel
    {
        private EventCatalogSingleton instance;
        public EventViewModel()
        {
            instance=EventCatalogSingleton.Instance;
        }
    }
}
