using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class HandleHomePageController : Controller
    {
        // GET: HandleHomePage
        public ActionResult Index()
        {
            return View();
        }
    }
}