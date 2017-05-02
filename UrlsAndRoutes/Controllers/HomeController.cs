using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.controller = "Home";
            ViewBag.action = "Index";
            ViewBag.url = HttpContext.Request.Url;
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id)
        {
            ViewBag.controller = "Customer";
            ViewBag.action = "List";
            ViewBag.url = HttpContext.Request.Url;
            ViewBag.CustomVariable = id;
            return View();
        }

        public ViewResult MyActionMethod()
        {
            string myActionUrl = Url.Action("Index", new { id = "MyID" });
            string myRouteUrl = Url.RouteUrl(new { controller = "Home", action = "Index" });
            return View();
        }
    }
}