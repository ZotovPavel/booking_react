using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Common.Models
{
    public class Country
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
