using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
namespace BookManagerFinal.Controllers
{
	public class BookController : Controller
	{
	     private BookContext context { get; set; }
 	     public BookController(BookContext ctx) => context = ctx;


        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new BookModel());
        }

 
        public IActionResult Index(int id, int rating)
        {
            ViewBag.id = id;
            ViewBag.Name = "Gerald";
            ViewBag.rating = rating;
            return View("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }
        //Delete()
	[HttpGet]
	public IActionResult Delete(int id)
	{
    	   var book = context.Books.Find(id);
           return View(book);
	}

	[HttpPost]
	public IActionResult Delete(BookModel book)
	{
 	   context.Books.Remove(book);
  	   context.SaveChanges();
    	   return RedirectToAction("Index", "Home");
	}
        public IActionResult Summary()
        {
            return View();
        }


    }
}

