using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.HIii";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult OurClients()
        {
            ViewBag.Message = "Clients";

            return View();
        }
        public ActionResult Routes()
        {
            ViewBag.Message = "The journey";

            return View();
        }
        public ActionResult Payments()
        {
            ViewBag.Message = "Make Payments here";

            return View();
        }
      


    }
}