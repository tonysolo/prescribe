using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prescribe.Models
{
    public class Patient
    {
            public Patient()
            {
            }
            public string Name { get; set; }
            public List<string> Contacts { get; set; }
            public List<string> Preferences { get; set; }
            public List<string> Alerts { get; set; }
            public List<Visit> Visits { get; set; }
        }

    }

