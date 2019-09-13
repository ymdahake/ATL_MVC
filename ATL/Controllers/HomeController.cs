using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATL.Models;

namespace ATL.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _db;
        public HomeController()
        {
            _db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Book> books = _db.Books.Include("Category").ToList();
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