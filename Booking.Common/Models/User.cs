using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Common.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Passport { get; set; }

        public int RoleID { get; set; }

        public virtual Role Roles { get; set; }
    }
}
