using System;

namespace CovidCert.Models
{
    public class Passport
    {

        public int Id { get; set; }

    
        public string? LastModifiedBy { get; set; }


        public DateOnly? LastModifiedDate { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }


        public bool? hasExpired { get; set; }
    }
}


