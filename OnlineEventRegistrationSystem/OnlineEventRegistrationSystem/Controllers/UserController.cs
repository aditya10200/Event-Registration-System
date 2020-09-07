using OnlineEventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        
        public string addClient(Client m)
        {

            Database1Entities4 db = new Database1Entities4();
            db.Clients.Add(m);
            db.SaveChanges();
            return "Successfully Registered";

        }
    }
}