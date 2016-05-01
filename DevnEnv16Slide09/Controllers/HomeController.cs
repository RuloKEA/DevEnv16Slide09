using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevnEnv16Slide09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello from home index";
        }

        public string Hello()
        {
            return "Hello from hello ";
        }


        public string Details(int? id )
        {
            return "Hello from details "+id;
        }

        public string HelloYou(string id)
        {
            return "Hello from helloyou "+id;
        }
    }
}