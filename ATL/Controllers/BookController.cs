using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATL.Models;
using ATL.Models.ViewModels;

namespace ATL.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext _db;
        public BookController()
        {
            _db = new ApplicationDbContext();
        }
        // GET: Book
        public ActionResult Index()
        {

            List<Book> books = _db.Books.Include("Category").ToList();
            return View(books);
        }



        public ActionResult Add()
        {
            BookViewModel book = new BookViewModel();
            book.Categories = _db.Categories.ToList();
            return View(book);
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            if(book.BookId!=null)
            {
                _db.Books.Add(book);
                _db.SaveChanges();
            }
            else
            {
                _db.Books
            }

           

            

            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            Book book = _db.Books.Single(item => item.BookId == id);
            return View(book);
        }

        public ActionResult Edit(int id)
        {

            BookViewModel bookViewModel = new BookViewModel()
            {
                Book = _db.Books.Single(item => item.BookId == id),
                Categories = _db.Categories.ToList()
            };
            return View("Add", bookViewModel);

                
        }
    }
}