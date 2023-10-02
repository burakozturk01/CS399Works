using System.Web.Mvc;

namespace ASPDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About ASP Demo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sen beni daha tanımamışsın.";

            return View();
        }
    }
}