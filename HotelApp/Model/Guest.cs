using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Handler;

namespace HotelApp.Model
{
    public class Guest
    {
        public int Guest_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Guest()
        {

        }

        public override string ToString()
        {
            return $"Navn: {Name}. Adresse: {Address}. GæsteID: {Guest_No}.";
        }
    }
}
