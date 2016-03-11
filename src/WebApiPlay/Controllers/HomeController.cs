using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiPlay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Second Commit
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
