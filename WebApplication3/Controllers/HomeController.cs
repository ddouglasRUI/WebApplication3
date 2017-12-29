using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Frequently Asked Questions.";

            return View();
        }

        public ActionResult ApproveRequests()
        {
            ViewBag.Message = "Approve Requests";

            return View();
        }
    }
}