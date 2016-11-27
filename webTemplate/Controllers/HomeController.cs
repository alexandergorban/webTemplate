using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using webTemplate.Models;

namespace webTemplate.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public IWeapon Weapon { get; set; }

        public ActionResult Index()
        {
            return View(Weapon);
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