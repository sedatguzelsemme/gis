using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GisCorp.Core.Services;

namespace GisCorp.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string test = Services.AccountService.DoSomething();
            ViewBag.DoSomething = test;
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