using CaptchaMvc.HtmlHelpers;
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
            ViewBag.Message3 = "What We Want To Achieve";
            ViewBag.Message4 = "More Information";
            ViewBag.Message5 = "Developers";
            ViewBag.message6 = "Mission Accomplished";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome, this is a form" +
                "that you can create when you need to contact us if you have " +
                "any specific questions about the website or how to use it." +
                "If you do not understand we recommned following the tutorials that we" +
                "have linked, or the blog post where other players have possibly posted some comments " +
                "about the game or tips. If that still does not help feel free to contact us." +
                "Thank you!";

            return View();
        }

        public ActionResult FAQ()
        {



            return View();
        }
        [Authorize]
        public ActionResult ExternalLinks()
        {

            return View();
        }

        public ActionResult Tutorial()
        {

            return View();
        }

        public ActionResult Acknowledgement()
        {

            return View();
        }
    }
}