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
                EventDate = "7/22",
                Description = "blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah",
                UserTask1 = "7/22 - Bring Food",
                UserTask2 = "7/29 - Team Building",
                Team = "Team: " + "Varisty Squad A",
                Unifrom_Color = "Uniform Colors: " + "Gold and Purple",
                Document1 = "Waiver",
                Document2 = "Travel Consent Form",

                EventName2 = "House Event",
                EventDate2 = "7/29",
                Description2 = "blah blah blah blah blah blah blah blah blah blah blah blah",
                Team2 = "Team: " + "Junior Varsity Squad A",
                Unifrom_Color2 = "Uniform Colors: " + "N/A",
                Document1_2 = "House Prep"
            };
            return View(myData);
        }

        public ActionResult Chat()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            var myData = new UserProfile
            {
                Email = "JohnDoe@gmail.com",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123-455-1234",
                Student = "Janice Doe",
                Address = "98123 1st st",
                Address2 = " ",
                City = "Lynnwood",
                St = "WA",
                Zip = 98253,
                emailContactmethod = true,
                phoneContactmethod = false,
                pwd = "***************"
            };

            return View(myData);
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}