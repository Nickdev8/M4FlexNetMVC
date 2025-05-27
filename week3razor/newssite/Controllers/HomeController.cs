using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;

namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        NewsItem item = new NewsItem()
        {
            Title = "tit1",
            Content = "ditis in ed contend",
            ImageUrl = "/imgaes/1.png"
        };
        return View(item);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
