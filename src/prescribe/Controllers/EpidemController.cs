using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
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
    public class EpidemController : Controller
    {
        // GET: /<controller>/      

        public string Test { get; set; }
        public string Gen { get; set; }

        public IActionResult Index()
        {
            var vm = new EpidemViewModel
            {
                IcDs = "C52 B43 C56",
                Treater = Epidemiolgy.Treater.Specialist
            };

            return View(vm);
        }
       
    }
}
