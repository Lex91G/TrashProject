using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using TrashProject.Models;
using Microsoft.AspNet.Identity;

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
            Address newaddress = new Address();
            ViewBag.Message = "Set up garbage pickups";
            

            return View(newaddress);
        }
        [HttpPost]
        public ActionResult SetUpPickUps(Address address)
        {
            string UserIDName = User.Identity.GetUserName();
            var user = (from x in Context.Users where x.UserName == UserIDName select x).First();
            address.User = user;
            Context.Addresses.Add(address);
            Context.SaveChanges();
            


            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Routes()
        {

            ViewBag.Message = "The journey";

            return View();
        }
        [HttpPost]
        public ActionResult Routes(Routes route)
        {
            
            ViewBag.addresses = (from x in Context.Addresses where x.ZipCode == route.Zipcode select x).ToList();
            
           

            return View("Routes2");
        }
        public ActionResult Routes2()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Payments()
        {
            string UserIDName= User.Identity.GetUserName();
            var user = (from x in Context.Users where x.UserName == UserIDName select x).First();
            List<Address> Addresses = (from x in Context.Addresses.Include("User") where x.User.Id == user.Id select x).ToList();
            
            //ViewBag.Meme = "Make Payments here"

            return View(Addresses);
        }
        [HttpPost]
        public ActionResult Payments(UserLoginInfo user)
        {

            Context.SaveChanges();



            return RedirectToAction("Index");
        }


    }



}
