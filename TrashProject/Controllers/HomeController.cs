using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using TrashProject.Models;


namespace TrashProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext Context;
        public HomeController()
        {
            Context = new ApplicationDbContext();
        }
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
        [HttpGet]
        public ActionResult SetUpPickUps()
        {
            Address address = new Address();
            ViewBag.Message = "Set up garbage pickups";
            

            return View(address);
        }
        [HttpPost]
        public ActionResult SetUpPickUps(Address address)
        {
            Context.Addresses.Add(address);
            Context.SaveChanges();
            


            return RedirectToAction("Payment");
        }
        public ActionResult Routes()
        {
            ViewBag.Message = "The journey";

            return View();
        }
        public ActionResult Payments()
        {
            PayBill payment = new PayBill();
            ViewBag.Message = "Make Payments here";

            return View(payment);
        }
        public ActionResult Payments(PayBill payment)
        {
            
            Context.SaveChanges();



            return RedirectToAction("Home");
        }


    }



}
