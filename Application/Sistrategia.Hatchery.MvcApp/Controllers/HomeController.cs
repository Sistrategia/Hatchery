using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hatchery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            // ViewBag.Title = "Home Page";

            if (!Request.IsAuthenticated) {
                return RedirectToAction("Welcome");
            }

            return RedirectToAction("Welcome");

            //return View();
        }

        public ActionResult Cover() {
            return View();
        }

        public ActionResult Welcome() {
            return View();
        }
    }
}
