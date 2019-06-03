using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tumble.Models;
using System.Web.Mvc;

namespace Tumble.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var myData = new HomeViewModel
            {
                EventName = "State Championship",
                Description = "blah blah blah",
                UserTask1 = "7/22 - Food",
                UserTask2 = "7/29 - Team Building"

            };
            return View(myData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}