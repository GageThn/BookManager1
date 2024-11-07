using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookManagerFinal.Models;
namespace BookManagerFinal.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        return View();
    }


}

