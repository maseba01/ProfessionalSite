using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalSite.Controllers
{
    public class NavBarController : Controller
    {
        // GET: NavBar
        public ActionResult NavBar()
        {
            return PartialView("_NavBar");
        }
    }
}