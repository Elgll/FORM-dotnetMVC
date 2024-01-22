using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using elena.galli._5i.primaWeb.Models;

namespace elena.galli._5i.primaWeb.Controllers;

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

     [HttpGet]
    public IActionResult Prodotti()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Prenota()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Conferma(Prenotazione pr)
    {
        return View(pr);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
