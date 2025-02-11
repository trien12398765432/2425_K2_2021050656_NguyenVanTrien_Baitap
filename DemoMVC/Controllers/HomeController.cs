
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenVanTrien.Models;

namespace NguyenVanTrien.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string fullname, string address)
    {
        string strOutput = "Xin Chào " + fullname + " đến từ " + address; 
        ViewBag.Message = strOutput;

        return View();
    }
}
