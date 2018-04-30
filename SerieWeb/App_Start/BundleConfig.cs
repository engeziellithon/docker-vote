﻿using System.Web;
using System.Web.Optimization;

namespace SerieWeb
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                      "~/Scripts/umd/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",                      
                      "~/Scripts/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/datatables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/BootstrapMultiselect").Include(
                      "~/Scripts/BootstrapMultiselect/BootstrapMultiselect.min.js"));

            bundles.Add(new StyleBundle("~/Content/multiselect").Include(
                                "~/Content/multiselect/multiselect.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/AdminCustom.css",
                      "~/Content/Datatables.css"));            
        }
    }
}
