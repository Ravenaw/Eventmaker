using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Eventmaker.Annotations;
using Eventmaker.Model;

namespace Eventmaker.ViewModel
{
    class EventViewModel:INotifyPropertyChanged
    {
        public EventCatalogSingleton instance { get; }
        public EventViewModel()
        {
            instance=EventCatalogSingleton.Instance;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
