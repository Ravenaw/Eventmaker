using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Eventmaker.Model;
using Newtonsoft.Json;

namespace Eventmaker.Persistency
{
    class PersistencyService
    {
        private const string _dataFile = "events.json";
        private readonly StorageFolder _storageFolder = ApplicationData.Current.LocalFolder;
        public async Task SaveDomainObject()
        {
            string Json = JsonConvert.SerializeObject(EventCatalogSingleton.Instance.EventCatalog);
            await FileIO.WriteTextAsync(await _storageFolder.CreateFileAsync(_dataFile, CreationCollisionOption.OpenIfExists), Json);
        }
        public async Task LoadDomainObject()
        {
            string events =
                await FileIO.ReadTextAsync(
                    await _storageFolder.CreateFileAsync(_dataFile, CreationCollisionOption.OpenIfExists));
            EventCatalogSingleton.Instance.EventCatalog = JsonConvert.DeserializeObject<ObservableCollection<Event>>(events);
            if (EventCatalogSingleton.Instance.EventCatalog == null)
            {
                EventCatalogSingleton.Instance.EventCatalog = new ObservableCollection<Event>();
            }
        }
    }
}
