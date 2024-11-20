using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
namespace BookManagerFinal.Controllers;

public class HomeController : Controller
{
    //dependency injection setup
    private BookContext context { get; set; }
    public HomeController(BookContext ctx) => context = ctx;
  
    public IActionResult Index()
    {
        var books = context.Books.OrderBy(m => m.Name).ToList();
        return View(books);
    }
}

