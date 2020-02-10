using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventmaker.Model;
using Newtonsoft.Json;

namespace Eventmaker.Persistency
{
    class PersistencyService
    {
        public static async void SaveEventsAsJsonAsync(ObservableCollection<Event> events)
        {
            StreamWriter sw = File.CreateText("file.txt");

        }

        public static async Task<List<Event>> LoadEventsFromJsonAsync()
        {

        }

        public static async void SerializeEventsFileAsync(string eventsString, string fileName)
        {

        }

        public static async Task<string> DeSerializeEventsFileAsync(String fileName)
        {
            return (List<Event>)(JsonConvert.DeserializeObject(eventString, typeof(List<Event>)));
        }

    }
}
