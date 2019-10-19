using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Common.Models
{
    public class Hotel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CityID { get; set; }

        public string Coordinates { get; set; }

        public int RaitingID { get; set; }

        public virtual Raiting Raiting { get; set; }

        public virtual City City { get; set; }
    }
}
