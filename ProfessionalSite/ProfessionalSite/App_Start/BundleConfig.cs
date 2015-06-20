using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ProfessionalSite.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/commoncss")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/Site.css")
                .Include("~/Content/Home.css")
                .Include("~/Content/carousel.css")
                .Include("~/Content/twitter.css")
                .Include("~/Content/skillbar.css")
                .Include("~/Content/nav-scroll.css")
                .Include("~/Content/navbar.css")
                );


            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-2.1.3.js")
                .Include("~/Scripts/jquery.easing.min.js")
                .Include("~/Scripts/nav-scroll.js")
                .Include("~/Scripts/skills.js")
                .Include("~/Scripts/waypoints.min.js")
                );

            BundleTable.EnableOptimizations = true;

        }
    }
}