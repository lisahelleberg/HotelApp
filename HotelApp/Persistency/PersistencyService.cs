using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using HotelApp.Model;
using System.Collections.ObjectModel;
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft;
//using Newtonsoft;
//using EventMaker.ViewModel;
//using Windows.Storage;
//using Windows.UI.Popups;
//using Newtonsoft.Json;
//using System.Reflection.Metadata;
//using System.Diagnostics;


namespace HotelApp.Persistency
{
    public class PersistencyService
    {
        const string serverUrl = "http://webservicehotel20170329012418.azurewebsites.net";
        static HttpClientHandler httpClientHandler = new HttpClientHandler();
        static System.Net.Http.HttpClient client = new System.Net.Http.HttpClient(httpClientHandler);

        public PersistencyService()
        {
            httpClientHandler.UseDefaultCredentials = true;
        }

        public static ObservableCollection<Guest> LoadGuestsFromJsonAsync()
        {
            using (client)
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/guests").Result;
                if (response.IsSuccessStatusCode)
                {
                    var guestListe = response.Content.ReadAsAsync<ObservableCollection<Guest>>().Result;
                    
                    return guestListe;
                }
                return null;
            }
        }
        public static void SaveGuestFromJsonAsync(Guest SingletonFile)
        {
            using (client)
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync<Guest>("api/guests", SingletonFile).Result;
            }

        }
    }
}
