using System;
using System.Net.Http;
using System.Net.Http.Headers;
using HotelApp.Model;
using System.Collections.ObjectModel;


namespace HotelApp.Persistency
{
    public class PersistencyService
    {
        const string serverUrl = "http://webservicehotel20170329012418.azurewebsites.net/api/Hotels/";
        static HttpClientHandler httpClientHandler = new HttpClientHandler();
        static System.Net.Http.HttpClient client = new System.Net.Http.HttpClient(httpClientHandler);

        public PersistencyService()
        {
            httpClientHandler.UseDefaultCredentials = true;
        }
        
        public static ObservableCollection<Guest> LoadGuestsFromJsonAsync()
        {
            using (client)
            { client.BaseAddress = new Uri(serverUrl);
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
                var response = client.PostAsJsonAsync<Guest<("api/guests", SingletonFile).Result;
            }

        }
    }
}
