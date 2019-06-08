using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tumble.Models;

namespace Tumble.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        // GET: Single Event
        public ActionResult SingleEvent()
        {
            var myData = new SingleEventViewModel
            {
                EventName = "Football Game Day",
                EventDate = DateTime.Parse("8/22/2019 1:30:00 PM",
                          System.Globalization.CultureInfo.InvariantCulture),
                Team =  "Varisty",
                Squad = "Squad A",
                Unifrom_Color = "Gold and Purple",
                Description = "blah balh blah balh balh blah balh blah balh balh",
                Location = "800 Occidental Ave S, Seattle, WA 98134",
                Cost = "$10.00",
            };
            return View(myData);
        }

        public ActionResult AddEventView()
        {
            return View();
        }
    }
}