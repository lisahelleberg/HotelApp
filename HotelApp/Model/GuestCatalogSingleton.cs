using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
//using HotelApp.Persistency;
using System.Diagnostics;
using System.ComponentModel;

namespace HotelApp.Model
{
    public sealed class GuestCatalogSingleton
    {
        private static GuestCatalogSingleton instance = new GuestCatalogSingleton();
        public static GuestCatalogSingleton SingletonInstance
        {
            get { return instance; }
        }
        public Guest SingletonFile { get; set; }
        public ObservableCollection<Guest> GuestList { get; set; }

        public GuestCatalogSingleton()
        {
            GuestList = new ObservableCollection<Guest>();
        }
        //public void AddGuest(Guest AddedGuest)
        //{
        //    GuestList.Add(AddedGuest);
        //    PersistencyService.
        //}
    }
}
