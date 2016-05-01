using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevnEnv16Slide09.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create(string name)
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public string TestAction()
        {
            return "String from controller";
        }
    }
}