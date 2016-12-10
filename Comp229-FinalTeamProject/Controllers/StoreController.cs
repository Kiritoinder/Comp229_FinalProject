using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comp229_FinalTeamProject.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "This is my Store Catalog Page";
            return View();
        }

        public ActionResult Browse(String genre)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Detsils, id= " + id);
            return View();
        }

        public ActionResult ShoppingCart()
        {
            ViewBag.Message = "This is my Shopping Cart Page";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "This is my Contact Page";
            return View();
        }
    }
}