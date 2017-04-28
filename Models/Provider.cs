using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prescribe.Models;

namespace prescribe.Models
{
    public class Provider
    {
        public Provider()
        {
        }
        public string Preferences { get; set; }
        public List<Patient> Patients { get; set; }
    }

}

