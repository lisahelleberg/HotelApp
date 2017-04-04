using HotelApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Model;
using HotelApp.ViewModel;

namespace HotelApp.Handler
{
    public class GuestHandler
    {
        public GuestViewModel GVM;
        public GuestHandler(GuestViewModel gvm)
        {
            this.GVM = gvm;
        }

        public void CreateGuest()
        {
            Guest TempGuest = new Guest();
            TempGuest.Name = GVM.guests.Name;
            TempGuest.Guest_No = GVM.guests.Guest_No;
            TempGuest.Address = GVM.guests.Address;
            //GuestCatalogSingleton.SingletonInstance.AddGuest(TempGuest);
        }
    }
}
