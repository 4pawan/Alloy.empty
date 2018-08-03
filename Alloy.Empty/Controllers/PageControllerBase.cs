using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alloy.Empty.Models.Pages;
using EPiServer.Core;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;

namespace Alloy.Empty.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
    {

        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        //public ActionResult Logout()
        //{
        //    UISignInManager.Service.SignOut();
        //    return RedirectToAction("Index");
        //}
    }
}