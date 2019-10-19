using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.Models
{
    public class HotelModel
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }

        public string HotelCoordinates { get; set; }

        public int RaitingId { get; set; }

        public string RaitingDescription { get; set; }
    }
}
