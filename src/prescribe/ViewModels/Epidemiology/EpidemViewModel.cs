using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prescribe.Models;


namespace prescribe.ViewModels.Epidemiology
{
    public class EpidemViewModel
    {
        [Required]
        [DisplayFormat(DataFormatString = "dd,mm,yyyy")]
        public DateTime Date { get; set; }
        [Required]
        public string IcDs { get; set; }
        [Required]
        public Epidemiolgy.AgeGroup AgeGroup { get; set; }
        [Required]
        public Epidemiolgy.Genders Gender { get; set; }
        [Required]
        public string RegionFrom { get; set; }
        [Required]
        public string RegionNow { get; set; }
        [Required]
        public Epidemiolgy.Treater ReferredBy { get; set; }
        [Required]
        public Epidemiolgy.Treater Treater{ get; set; }
        [Required]
        public Epidemiolgy.SpecialtyType Specialty{ get; set; }
        [Required]
        public Epidemiolgy.Facilitytype Facility { get; set; }
        [Required]
        public Epidemiolgy.Treatmentmode InOutPatient { get; set; }
        [Required]
        public byte DaysorVisits { get; set; }
        public string AzureQneRegion { get; set; }  //all epidemiolgy uses ghg account
        public string Href() //returns this to submit button to store in queue with secs to midnight delay
        {
            return "";
        }
    }  
}
   

