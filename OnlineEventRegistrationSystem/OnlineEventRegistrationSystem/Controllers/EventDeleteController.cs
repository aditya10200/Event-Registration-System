using OnlineEventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class EventDeleteController : Controller
    {
        // GET: EventDelete
        public ActionResult Index()
        {
            return View();
        }

        public string del(string EMAIL)
        {
            Database1Entities4 ent = new Database1Entities4();

            Register em = ent.Registers.First(x => x.Email == EMAIL);
            ent.Registers.Remove(em);
            ent.SaveChanges();

            return "Successfully Deleted";
        }
        
        public string del2(string NAME)
        {
            Database1Entities4 ent1 = new Database1Entities4();
            List<Register> registers = ent1.Registers.Where(x => x.EventName == NAME).ToList();
            foreach(var i in registers)
            { ent1.Registers.Remove(i); }
            ent1.SaveChanges();
            return "Deleted Successfully";

        }
    }
}