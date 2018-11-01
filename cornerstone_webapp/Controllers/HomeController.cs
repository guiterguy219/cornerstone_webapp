using cornerstone_webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cornerstone_webapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Home");
        }

        public ActionResult Home()
        {
            InspectionRequest currentRequest = (InspectionRequest)TempData["currentRequest"];

            return View("Home", currentRequest);
        }
    }
}