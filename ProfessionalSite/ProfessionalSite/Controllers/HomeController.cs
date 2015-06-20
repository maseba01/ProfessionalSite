using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carousel()
        {
            return PartialView("_Carousel");
        }

        public ActionResult Contact()
        {
            return PartialView("_Contact");
        }
    }
}