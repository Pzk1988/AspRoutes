using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.controller = "Admin";
            ViewBag.action = "Index";
            ViewBag.url = HttpContext.Request.Url;
            return View("ActionName");
        }
    }
}