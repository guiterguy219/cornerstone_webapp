using cornerstone_webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cornerstone_webapp.Controllers
{
    public class RequestController : Controller
    {
        static public InspectionRequest currentRequest = new InspectionRequest();

        // GET: Request
        public ActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestForm(InspectionRequest request)
        {
            if (ModelState.IsValid)
            {
                request.IsSubmitted = true;

                TempData["currentRequest"] = request;

                return RedirectToAction("Home", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}