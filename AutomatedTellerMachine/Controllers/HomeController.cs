using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        public ActionResult Index()
        {
            return View();
        }

        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Please send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks for your message";

            return View();
        }

        public ActionResult Pineapple()
        {
            ViewBag.TheMessage = "Thanks for your message";

            return View();
        }

        // create method Foo() that aliases the About page
        public ActionResult Foo()
        {
            return View("About");
        }


        public ActionResult Serial(string letterCase)
        {
            var serial = "The rabbit machine serial number is 234535";
            if(letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("About");
        }
    }

}