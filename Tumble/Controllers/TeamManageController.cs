﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tumble.Controllers
{
    public class TeamManageController : Controller
    {
        // GET: TeamManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamManage
        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult ManageUser()
        {
            return View();
        }
    }
}