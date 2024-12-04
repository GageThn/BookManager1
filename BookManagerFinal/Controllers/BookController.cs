using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
namespace BookManagerFinal.Controllers
{
	public class BookController : Controller
	{

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
        public IActionResult Delete()
        {
            ViewBag.Action = "Delete";
            return View();
        }
        public IActionResult Summary()
        {
            return View();
        }


    }
}

