using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoUIDemo.Models;

namespace KendoUIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var movies = MovieFactory.Create();

            return View(movies);
        }

        public JsonResult Ajax()
        {
            var movies = MovieFactory.Create();
            return Json(movies, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
