using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IPChecker2.Models;
using System.Net;

namespace IPChecker2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

    public IActionResult CheckIp()
    {
        var remoteIp = Dns.GetHostAddresses(Dns.GetHostName());

        return Content($"Your IP: {remoteIp}");
    }
}
