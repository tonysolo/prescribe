using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prescribe.Models
{
    public class Epidemiology
    {
        public enum Genders
        {
            Male, Female
        }

        public enum AgeGroup
        {
            PremNeonate,
            ExPrem,
            Neonate,
            LessThanThreeMonths,
            LessThanOneYear,
            OneToThreeYears,
            ThreeToSixYears,
            SixtoTwelveYears,
            ThirteenToTwenty,
            TwentyToForty,
            FortyToSixty,
            SixtyToEighty,
            EightyPlus
        }

        public enum Treater
        {
            TraditionalHealer, HomeoPath, CommunityWorker, Therapist, ProfessionalNurse, GeneralPractitioner, Specialist
        }

        public enum SpecialtyType
        {
            PublicHealth, GeneralPractice, Anaesthetics, Surgery, ObstetsGynae, Orthopaedics, Neurology
        }

        public enum Facilitytype
        {
            GeneralPractice, OutpatientClinic, PublicHospital, PrivateHospital
        }

        public enum Treatmentmode
        {
            Inpatient, OutPatient
        }


        public string IcDs { get; set;}

        public AgeGroup Age{ get; set; }
        public Genders Gender { get; set; }
        public string RegionFrom { get; set; }
        public string RegionNow { get; set; }
        public Treater ReferredBy { get; set; }
        public Treater TreatedBy { get; set; }
        public SpecialtyType Specialty { get; set; }
        public Facilitytype FacilityType { get; set; }
        public Treatmentmode InOutPatient { get; set; }
        public byte DaysorVisits { get; set; }
    }
    
}


