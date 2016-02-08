using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prescribe.Models
{
    public class Epidemiolgy
    {
        public enum Gender
        {
            Male,
            Female = 1
        }
        public string IcDs { get; set; }
        public byte AgeGroup { get; set; }
        public byte Gend { get; set; }
        public string RegionFrom { get; set; }
        public string RegionNow { get; set; }
        public byte ReferredBy { get; set; }
        public byte TreatedBy { get; set; }
        public byte Specialty { get; set; }
        public byte Facility { get; set; }
        public byte InOutPatient { get; set; }
        public byte DaysorVisits { get; set; }
    }
}


