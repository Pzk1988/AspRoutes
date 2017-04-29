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
        // GET: Admiin
        public ActionResult Index(string name = null)
        {
            Debug.WriteLine(name);
            ViewBag.controller = "Admin";
            ViewBag.action = "Index";
            return View("ActionName");
        }
    }
}