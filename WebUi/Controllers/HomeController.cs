using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUi.Attributes;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthorize]
        public ActionResult Index()
        {
            return View();
        }
        public string Hello( string SomeString, string dva)
        {
            return SomeString  + dva;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}