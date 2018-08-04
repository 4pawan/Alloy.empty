using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Alloy.Empty.Business.Initialization
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        private void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/JS").Include(
                "~/Static/JS/jquery-1.8.3.min.js",
                "~/Static/JS/jquery-ui.min.js",
                "~/Static/JS/jquery*",
                "~/Static/JS/responsee.js*",
                "~/Static/owl-carousel/owl.carousel.js*",
                "~/Static/JS/template-scripts.js"));

            bundles.Add(new StyleBundle("~/bundles/CSS").Include(
               "~/Static/css/components.css")
                .Include("~/Static/css/icons.css")
            .Include("~/Static/css/responsee.css")
            .Include("~/Static/owl-carousel/owl.carousel.css")
            .Include("~/Static/owl-carousel/owl.theme.css")
            .Include("~/Static/css/template-style.css"));
        }

        public void Uninitialize(InitializationEngine context)
        {

        }
    }
}