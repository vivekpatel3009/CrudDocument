using System.Web;
using System.Web.Optimization;

namespace PracticleCRUD
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

    
            #region JS Libraries

            bundles.Add(new ScriptBundle("~/bundles/projectJS/jQueryJs").Include(
                "~/Scripts/projectJS/jquery.js",
                "~/Scripts/projectJS/jquery-ui.min.js",
                "~/Scripts/projectJS/jquery.validate.js",
                "~/Scripts/projectJS/jquery.validate.unobtrusive.js",
                "~/Scripts/projectJS/jquery.dataTables.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/projectJS/modernizr").Include(
                     "~/Scripts/projectJS/modernizr-2.8.3.js"));
            bundles.Add(new ScriptBundle("~/bundles/projectJS/bootstrap").Include(
                 "~/Scripts/projectJS/bootstrap.min.js",
                 "~/Scripts/projectJS/bootstrap-datepicker.js",
                 "~/Scripts/projectJS/dataTables.bootstrap.min.js",
                    "~/Scripts/projectJS/toastr.min.js"));
            // Other Libraries
            bundles.Add(new ScriptBundle("~/bundles/projectJS/otherLib").Include(
                      "~/Scripts/projectJS/daterangepicker.js"
                     ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //           "~/Scripts/jquery-3.3.1.min.js",
            //           "~/Scripts/jquery.dataTables.min.js"
            //            ));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));
            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            ////bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            ////            "~/Scripts/modernizr-*"));
            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //           "~/Scripts/bootstrap.min.js",
            //           "~/Scripts/dataTables.bootstrap.min.js",
            //           "~/Scripts/bootstrap-datepicker.js"
            //          ));
            #endregion

            #region CSS Libraries

            bundles.Add(new StyleBundle("~/Content/ProjectCss/bootstrapCss").Include(
                    "~/Content/ProjectCss/bootstrap.min.css",
                    "~/Content/ProjectCss/bootstrap-datepicker.min.css",
                    "~/Content/ProjectCss/dataTables.bootstrap.min.css"));

            // Other CSS Bundle
            bundles.Add(new StyleBundle("~/Content/ProjectCss/otherCss").Include(
                      "~/Content/ProjectCss/_all-skins.min.css",
                      "~/Content/ProjectCss/daterangepicker.css",
                      "~/Content/ProjectCss/toastr.min.css"
                     ));
            // Font CSS Bundle
            bundles.Add(new StyleBundle("~/Content/ProjectCss/fontCss").Include(
                      "~/Content/ProjectCss/font-awesome.min.css"));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //    "~/Content/bootstrap.min.css",      
            //    "~/Content/datepicker.css",                      
            //    "~/Content/site.css"));
        }
    }
        #endregion

}
