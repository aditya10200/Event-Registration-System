using OnlineEventRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class UpdateClientController : Controller
    {
        // GET: UpdateClient
        public ActionResult Index()
        {
            return View();
        }    
        
        public string upd(string EMAIL, string ADDRESS, string PHONE)
        {
            Database1Entities4 db2 = new Database1Entities4();
            var cli = db2.Clients.First(a => a.Email == EMAIL);
            cli.Address = ADDRESS;
            cli.Phone = PHONE;
            db2.SaveChanges();

            return "Updated Successfully";
        }
    }
}