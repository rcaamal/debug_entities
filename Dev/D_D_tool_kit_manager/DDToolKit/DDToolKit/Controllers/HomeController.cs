﻿using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DDToolKit.Controllers

{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vision Statement.";
            ViewBag.Message2 = "Goals";
            ViewBag.Message3 = "What we want to Achieve";
            ViewBag.Message4 = "More Information";
            ViewBag.Message5 = "Developers";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome";

            return View();
        }

        public ActionResult FAQ()
        {



            return View();
        }

        public ActionResult ExternalLinks()
        {

            return View();
        }

        public ActionResult Tutorial()
        {

            return View();
        }
    }
}