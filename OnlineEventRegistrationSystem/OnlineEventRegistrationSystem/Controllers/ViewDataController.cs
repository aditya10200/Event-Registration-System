using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineEventRegistrationSystem.Models;


namespace WebApplication2.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Database1Entities4 db = new Database1Entities4();
            var emp = from e in db.Clients
                      orderby e.Email
                      select e;
            return View(emp);
        }

        public ActionResult ViewEventData()
        {
            Database1Entities4 db = new Database1Entities4();
            var emp = from e in db.Registers
                      orderby e.Id
                      select e;
            return View(emp);
        }
    }
}

