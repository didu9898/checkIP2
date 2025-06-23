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
        return Content($"Your host: {Dns.GetHostName()}");
        // var hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
        // 
        // string host = "";
        // foreach (var ip in hostAddresses)
        // {
        //     try
        //     {
        //         var hostEntry = Dns.GetHostEntry(ip);
        //         host = host + $"{ip} → {hostEntry.HostName}";
        //     }
        //     catch
        //     {
        //         host = host + $"{ip} → host name not found";
        //     }
        // }
        // 
        // return Content($"Your host: {host}");
    }
}
