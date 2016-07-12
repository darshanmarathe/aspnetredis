using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoRedisCache.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["RedisData"] = "This is stored in Redis Server , time - " + DateTime.Now.ToLongTimeString();
            return View();
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