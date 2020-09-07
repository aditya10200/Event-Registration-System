using OnlineEventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public string reg(Register model)
        {
            
                Database1Entities4 db = new Database1Entities4();
                db.Registers.Add(model);
                db.SaveChanges();
                return "Successfully Registered";
           
        }
    }
}