using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        // Add a comment
        // bagayialow
        // bagayialow2

        public ActionResult Aus()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aus2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aus3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aus4()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}