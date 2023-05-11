using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ds2.Models;

namespace ds2.Controllers;

public class ServicoController : Controller
{
    private readonly ILogger<ServicoController> _logger;

    public ServicoController(ILogger<ServicoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}