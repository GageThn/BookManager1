using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
using static System.Reflection.Metadata.BlobBuilder;
using System.Net;
using Microsoft.EntityFrameworkCore;
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

    public IActionResult Summary(int id)
    {
        var book = context.Books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    public IActionResult Edit(int id)
    {
        var book = context.Books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
    [HttpGet]
    public IActionResult Add()
    {

        ViewBag.Action = "Add";
        return View("Add", new BookModel());
    }
    public IActionResult Delete(int id)
    {
        var book = context.Books.FirstOrDefault(b => b.BookId == id);

        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }
}

