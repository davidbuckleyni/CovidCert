using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCert.Models
{
   public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public DateOnly? Dob { get; set; }


        public string? MobileNumber { get; set; }

        public string? NIDirectUserName { get; set; }


        public string? Password { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }


        public bool? hasExpired { get; set; }

    }
}
