using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCert.Models
{
  public  class GovermentId
    {

        public enum GoverMentIdType
        {
            UKDrivingLicense=0,
            EUDrivingLicense=1,
            NorthernIrelandLicense=2,
            ScottishLicense=3,
            BirthCertificate=4,
            NhsCard=5

        }

        public int? Id { get; set; }

        public int? Type { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isActive { get; set; }


        public bool? hasExpired { get; set; }

    }
}
