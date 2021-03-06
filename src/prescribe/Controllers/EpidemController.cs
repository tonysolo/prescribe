﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Dnx.Compilation.Caching;
using prescribe.Models;
using prescribe.ViewModels.Epidemiology;

//public string IcDs { get; set; }
//public byte AgeGroup { get; set; }
//public Genders Gender { get; set; }
//public string RegionFrom { get; set; }
//public string RegionNow { get; set; }
//public Treater ReferredBy { get; set; }
//public Treater TreatedBy { get; set; }
//public SpecialtyType Specialty { get; set; }
//public Facilitytype FacilityType { get; set; }
//public Treatmentmode InOutPatient { get; set; }
//public byte DaysorVisits { get; set; }

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace prescribe.Controllers
{

 [Route("[controller]")]
    public class EpidemController : Controller
 {
     private Models.Epidemiology Epi { get; set; }
 
     // GET: /Epidem/             
     public string Test { get; set; }

     public string Gen { get; set; }

        [HttpGet("")]
        public IActionResult Index()
        {
            Epi = new Epidemiology
            {
                Age = Epidemiology.AgeGroup.Neonate,
                DaysorVisits = 1,
                FacilityType = Epidemiology.Facilitytype.GeneralPractice,
                Gender = Epidemiology.Genders.Female,
                IcDs = "X123",
                InOutPatient = Epidemiology.Treatmentmode.Inpatient,
                ReferredBy = Epidemiology.Treater.CommunityWorker,
                RegionFrom = "",
                RegionNow = "",
                Specialty = Epidemiology.SpecialtyType.GeneralPractice
            };

            var x = RouteData;
            var vm = new EpidemViewModel
            {
                Date = DateTime.Now,
                AgeGroup = Epi.Age,
                Gender = Epi.Gender,
                IcDs = Epi.IcDs
                 
            };

            // IcDs = "C52 B43 C56",
            //  Treater = Epidemiology.Treater.Specialist,
            //   RegionFrom = "qnnee",
            //  RegionNow = "21233"
        
            return View(vm);
        }
[HttpPost]
 public ActionResult Post()
        {     
            return Content("post invoked");

        }

      [HttpPost("Stuff")]
        public ActionResult Post([FromBody]string firstname)
        {     
            return Content("post stuff invoked");

        }

    }
}
