using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // TODO: access a model

            return View();
        }

        public string Hello()
        {
            return "Hello, World!";
        }
    }
}