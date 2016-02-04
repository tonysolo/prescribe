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

        public Gender Gen { get; set; }


    }
}

       
    