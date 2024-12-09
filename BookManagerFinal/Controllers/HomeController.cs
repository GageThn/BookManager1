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

    [HttpGet]
    public IActionResult Edit(int id)
    {
        ViewBag.Action = "Edit";
        var book = context.Books.Find(id);
        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(BookModel book)
    {
        if (ModelState.IsValid)
        {
            if (book.BookId == 0)
            {
                context.Books.Add(book);
            }
            else
            {
                context.Books.Update(book);
            }
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ViewBag.Action = (book.BookId == 0) ? "Add" : "Edit";

            return View(book);
        }

    }

    [HttpGet]
    public IActionResult Add()
    {

        ViewBag.Action = "Add";
        return View("Add", new BookModel());
    }

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
}

