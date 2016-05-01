using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevnEnv16Slide09.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello(string id)
        {
            ViewBag.name = id;
            return View();
        }

        public string Junk()
        {
            return "jkhjkhkjhkjhkjhkhj";
        }
    }
}