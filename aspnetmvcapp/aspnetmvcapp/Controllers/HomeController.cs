using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvcapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn more about the frontend application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get help with the frontend application.";

            return View();
        }
    }
}