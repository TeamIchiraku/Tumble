using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tumble.Models;
using System.Web.Mvc;

namespace Tumble.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SingleTask()
        {
            var myData = new SingleTask
            {
                TaskName = "Food Prep",
                TaskDescription = "blah balh blah balh balh blah balh blah balh balh",
                EventDate = DateTime.Parse("7/22/2019 1:30:00 PM",
                          System.Globalization.CultureInfo.InvariantCulture),
                Req1 = "Something",
                Req2 = "Something",
                TotalNumber = 2,
                NumberFilled = 1,
                FAQDoc = "Food Prep"


            };
            return View(myData);
        }
    }
}