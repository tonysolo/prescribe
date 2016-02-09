using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prescribe.ViewModels.Epidemiology
{
    public class EpidemViewModel
    {
        [Required]
        [DisplayFormat(DataFormatString = "dd,mm,yyyy")]
        public DateTime Date { get; set; }
        public enum Gender{ Male, Female}
        [Required]
        public string IcDs { get; set; }
        [Required]
        public byte AgeGroup { get; set; }
        [Required]
        public Gender Gend { get; set; }
        [Required]
        public string RegionFrom { get; set; }
        [Required]
        public string RegionNow { get; set; }
        [Required]
        public byte ReferredBy { get; set; }
        [Required]
        public byte TreatedBy { get; set; }
        [Required]
        public byte Specialty { get; set; }
        [Required]
        public byte Facility { get; set; }
        [Required]
        public byte InOutPatient { get; set; }
        [Required]
        public byte DaysorVisits { get; set; }   
    }  
}
   

