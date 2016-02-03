using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Design;

namespace prescribe.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }

        public Person()
        {
        }

        public Person(string str)
        {
            var stn = str.Split(',');
            Id = stn[0];
            FName = stn[1];
            SName = stn[2];

        }
    }


    public class Patient : Person
    {
        public Patient(string str)
        {
            var stn = str.Split(',');
            Id = stn[0];
            FName = stn[1];
            SName = stn[2];
        }

    }

    public class Provider : Person
    {
        public List<Patient> RecentPatients;
    }

}

