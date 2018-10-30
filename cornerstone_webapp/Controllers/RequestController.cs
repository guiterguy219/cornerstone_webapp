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
        public List<string> typeOptions = new List<string>();

        // GET: Request
        public ActionResult RequestForm()
        {
            typeOptions.Add("Realtor");
            typeOptions.Add("Buyer");
            typeOptions.Add("Home Owner");

            ViewBag.TypeOptions = typeOptions;

            return View();
        }

        [HttpPost]
        public ActionResult RequestForm(InspectionRequest request)
        {
            if (ModelState.IsValid)
            {
                request.IsSubmitted = true;

                return View("Home", request);
            }
            else
            {
                typeOptions.Add("Realtor");
                typeOptions.Add("Buyer");
                typeOptions.Add("Home Owner");

                ViewBag.TypeOptions = typeOptions;

                return View();
            }
        }
    }
}