using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATL.Models;
using Microsoft.AspNet.Identity;
using ATL.Models.ViewModels;

namespace ATL.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _db;
        public UserController()
        {
            _db = new ApplicationDbContext();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subscribe(UserBookSubscriptionViewModel ubsvw)
        {

            if(!ModelState.IsValid)
            {
                return View("Index", "User");
            }
            Book book = _db.Books.Single(item => item.BookId == ubsvw.BookId);
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = _db.Users.FirstOrDefault(item => item.Id == currentUserId);
            UserBookSubscription ubs = new UserBookSubscription();
            ubs.BookId = book.BookId;
            ubs.UserId = currentUser.Id;
            ubs.CreateDate = DateTime.Now;
            ubs.FromDate = ubsvw.FromDate;
            ubs.ToDate = ubsvw.ToDate;
            _db.UserBookSubscriptions.Add(ubs);
            _db.SaveChanges();
            return View("Index","User");


        }
    }
}