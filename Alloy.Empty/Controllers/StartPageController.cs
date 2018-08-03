using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Alloy.Empty.Models.Pages;

namespace Alloy.Empty.Controllers
{
    public class StartPageController : PageControllerBase<Models.Pages.StartPage>
    {
        // GET: StartPage
        public ActionResult Index()
        {
            return View();
        }
    }
}