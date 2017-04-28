using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prescribe.Models
{
    public class Visit
    {   
            public string Date { get; set; }
            public string Description { get; set; }
            public string Icd10 { get; set; }
            public List<string> ImageIds { get; set; }
            public string Nextappointment { get; set; }
            public Visit()
            {
            }
        }
    }

