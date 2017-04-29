using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.controller = "Customer";
            ViewBag.action = "Index";
            return View("ActionName");
        }

        public ActionResult List(string name = null)
        {
            ViewBag.controller = "Customer";
            ViewBag.action = "List";
            ViewBag.msg = name;
            return View("ActionName");
        }
    }
}