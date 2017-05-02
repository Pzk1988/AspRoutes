using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    [RoutePrefix("Users")]
    public class CustomerController : Controller
    {
        [Route("~/Test")]
        public ActionResult Index()
        {
            ViewBag.controller = "Customer";
            ViewBag.action = "Index";
            ViewBag.url = HttpContext.Request.Url;
            return View("ActionName");
        }

        [Route("Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return String.Format("User {0}, id {1}", user, id);
        }

        [Route("Add/{user}/{password:alpha:minLength(3)}")]
        public string ChangePass(string user, string password)
        {
            return String.Format("User {0}, pass {1}", user, password);
        }
    }
}