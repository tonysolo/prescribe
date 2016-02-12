using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Design;

namespace prescribe.Models
{
    public class Visit
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; } //location,image_type, TTLive

    }

    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }

        public Person(string str)
        {
            var stn = str.Split(',');
            Id = stn[0];
            FirstName = stn[1];
            LastName = stn[2];
           
        }
    }


    public class Patient : Person
    {
        public byte[] PopulationHealthRisk { get; set; }
        public List<Visit> Visits { get; set; }

        public Patient(string str)
        {
            var stn = str.Split(',');
            Id = stn[0];
            FirstName = stn[1];
            LastName = stn[2];
        }

    }

    public class Provider : Person
    {
        public List<Patient> RecentPatients;
    }

}

