using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AutoSerwisOnlineIntra.Models;

namespace AutoSerwisOnlineIntra.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Logout()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Services()
    {
        return View();
    }
    
    public IActionResult EditService()
    {
        return View();
    }
    
    public IActionResult CarParts()
    {
        return View();
    }

    public IActionResult Help()
    {
        return View();
    }
    
    public IActionResult TermsAndConditions()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}