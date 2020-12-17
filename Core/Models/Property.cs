using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rooms { get; set; }
        public int Bedrooms { get; set; }
        public int Floor { get; set; }
        public int Bathrooms { get; set; }
        public string Balcony { get; set; }
        public string Orientation { get; set; }
        public bool AC { get; set; }
        public bool SteamHeating { get; set; }
        public bool Elevator { get; set; }
        public bool NewBuilding { get; set; }
        public int Cost { get; set; }
        public int Deposit { get; set; }
        public int Brokerage { get; set; }
        public int Space { get; set; } // m^2
        public string ServiceType { get; set; } //enum
        public string EstateType { get; set; }// enum
        public string FurnishType { get; set; } // enum
        public string Area { get; set; } // moze i Enum da bide ova

         
        //public string MainPhotoUrl { get; set; }
        //public IQueryable<string> ImageUrls { get; set; }

    }
}
