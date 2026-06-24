using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KhimMVC.Models;

namespace KhimMVC.Controllers;

[Route("[controller]")]
public class HomeController : Controller
{
    [HttpGet("Products")]
    public IActionResult ProductList()
    {
        List<string> products = new()
        {
            "Iphone 19 ProMax",
            "MacBook Pro m2",
            "Headphone",
            "Meta Glasses",
            "Smart TV 4.9"
        };
        ViewBag.Products = products;
        return View();
    }
}
