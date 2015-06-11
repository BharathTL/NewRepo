using System.Web;
using System.Web.Optimization;

namespace HookedMedia
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/angular.min.js",
                      "~/Scripts/angular-route.min.js",
                      "~/Scripts/application-93c3503e2a15e3f300a737f9d08e9a67.js",
                      "~/Scripts/chart-ae7b110ea76072029176c5a40065d75f.js",
                      "~/Scripts/common.js",
                      "~/Scripts/controls.js",
                      "~/Scripts/dashboard-8a64d6a40f59c658325742a13ce4d08a.js",
                      "~/Scripts/geocoder.js",
                      "~/Scripts/main.js",
                      "~/Scripts/map.js",
                      "~/Scripts/marker.js",
                      "~/Scripts/onion.js",
                      "~/Scripts/places.js",
                      "~/Scripts/places_impl.js",
                      "~/Scripts/stats.js",
                      "~/Scripts/util.js",
                       "~/Scripts/FileHandler.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/Application/HookedMedia.js",
                "~/Scripts/Application/route.js",
                "~/Scripts/Application/Controllers/NewCampaign.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/application-f1ef709c9b7efa3fc00769431a42f6f0.css",
                      "~/Content/css.css"));
        }
    }
}
