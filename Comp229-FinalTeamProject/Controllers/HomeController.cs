using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comp229_FinalTeamProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Title = "About";
            ViewBag.Inder = "Inder";

            return View();
        }

        [Authorize]


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [Authorize(Users = "IIKA")]
        public ActionResult IIKASecrets()
        {
            ViewBag.Message = "Your Administration page.";
            return View();
        }


        [Authorize(Roles = "Administrators")]
        public ActionResult AdministratorSecrets()
        {
            return View();
        }


    }
}