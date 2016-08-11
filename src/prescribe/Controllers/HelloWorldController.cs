using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace prescribe.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["message"] = "Hello " + "Tony";
            ViewData["numtimes"] = 10;
            return  View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //var x = ViewData.Add();
            //ViewData.Model
            ViewData["message"] = "Hello "+ name;
            ViewData["numtimes"] = numTimes;
            return View();
        }
//HelloWorld/Welcome?Name=T Manicom&numTimes=5
    }
}
