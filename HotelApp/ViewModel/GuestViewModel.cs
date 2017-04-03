using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Model;
using System.ComponentModel; 

namespace HotelApp.ViewModel
{
    public class GuestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public GuestCatalogSingleton SingletonInstance;
        public Guest guests;
    }
}
