using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using prescribe.Models;
using prescribe.ViewModels.Epidemiology;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace prescribe.Controllers
{
    public class EpidemController : Controller
    {
        // GET: /<controller>/      

        public string Test { get; set; }

        public IActionResult Index()
        {
            var vm = new EpidemViewModel {IcDs = "C52 B43 C56"};
            //Gender = vm.Gend.ToString();
            return View(vm);
            //string s = "Test";
            //return View("EpidemView");
        }
        public string Gender { get; set; }

        //(string)Epidemiolgy.Gender. ;
    }
}
