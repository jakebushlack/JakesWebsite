using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JakesWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me!";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's get in touch! You can get a hold of me by any of these means:";
            return View();
        }
    }
}