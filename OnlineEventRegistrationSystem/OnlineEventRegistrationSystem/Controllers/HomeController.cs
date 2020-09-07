using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to start ASp.net";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page ";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";
            return View();
        }
    }
}