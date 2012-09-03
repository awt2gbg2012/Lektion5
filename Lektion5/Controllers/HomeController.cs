using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion5.Models.DummyForDebugging;

namespace Lektion5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = string.Format("Hello {0}! Your birthday is {1:d}", "David", DateTime.Parse("1889-12-21")); // :d i min formatstring gör så att ett datum skrivs ut på kort-format. Det finns en enorm mängd sådana formatteringsregler man kan slänga på

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
