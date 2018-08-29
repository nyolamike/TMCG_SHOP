using System.Web;
using System.Web.Optimization;

namespace Eshop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery.js",
                        "~/Scripts/js/popper.js",
                        "~/Scripts/js/bootstrap.js",
                        "~/Scripts/js/jquery.easing.1.3.js",
                        "~/Scripts/js/jquery.waypoints.min.js",
                        "~/Scripts/js/jquery.flexslider-min.js",
                        "~/Scripts/js/owl.carousel.min.js",
                        "~/Scripts/js/jquery.magnific-popup.js",
                        "~/Scripts/js/magnific-popup-options.js",
                        "~/Scripts/js/bootstrap-datepicker.js",
                        "~/Scripts/js/jquery.stellar.js",
                        "~/Scripts/js/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

    
             bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/animate.css",
                      "~/Content/css/icomoon.css",
                      "~/Content/css/ionicons.css",
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/owl.theme.default.css",
                      "~/Content/css/bootstrap-datepicker.css",
                      "~/Content/fonts/flaticon/font/flaticon.css",
                      "~/Content/css/style.css"));
      
        }
    }
}
