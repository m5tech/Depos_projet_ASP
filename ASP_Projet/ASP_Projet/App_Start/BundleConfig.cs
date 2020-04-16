﻿using System.Web;
using System.Web.Optimization;

namespace ASP_Projet
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            //////////////////////////////////

            bundles.Add(new StyleBundle("~/template/css").Include("~/Content/css/agency.css", "~/Content/vendor/fontawesome-free/css/all.min.css", "~/Content/vendor/bootstrap/css/bootstrap.min.css"));
            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/jqBootstrapValidation.js", "~/Scripts/contact_me.js", "~/Scripts/agency.min.js", "~/Content/vendor/jquery-easing/jquery.easing.min.js", "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js", "~/Content/vendor/jquery/jquery.min.js"));
        }
    }
}
