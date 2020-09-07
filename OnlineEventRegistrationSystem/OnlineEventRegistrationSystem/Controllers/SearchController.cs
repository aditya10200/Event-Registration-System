using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineEventRegistrationSystem.Models;

namespace OnlineEventRegistrationSystem.Controllers
{
    public class SearchController : Controller
    {
        //public string eventName { get; private set; }
        //public string date { get; private set; }
        // GET: Search
        List<Event> s;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult view(string eventName, string date)
        {
            Database1Entities4 db = new Database1Entities4();

            if (eventName != "")
            {
                s = db.Events.Where(x => x.EventName == eventName).ToList();

            }
            else if (date != "")
            {

                s = db.Events.Where(x => x.Date == date).ToList();

            }
            var temp = from x in s
                       select x;
            return View(temp);

        }
    }
}