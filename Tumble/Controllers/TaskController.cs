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
                TaskName = "Carpool Duty",
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

        public ActionResult AssignTask()
        {
            var myData = new AssignTaskModel
            {
                TaskName1 = "CarpoolDuty",
                TaskName2 = "Food Supply",
                TaskName3 = " Clean Up",
                TaskDescription = "blah balh blah balh balh blah balh blah balh balh",
                Req1 = "Somthing",
                FAQDoc = "FAQ Document",
                User1 = "Bob",
                User2 = "John"
            };
            return View(myData);
        }
    }
}