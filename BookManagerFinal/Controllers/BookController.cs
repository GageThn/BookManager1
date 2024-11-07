using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
namespace BookManagerFinal.Controllers
{
	public class BookController : Controller
	{
		public BookController()
		{

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
            return View();
        }
        public IActionResult Summary()
        {
            return View();
        }


    }
}

