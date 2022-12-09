using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey_Validations.Models;

namespace DojoSurvey_Validations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost("user/create")]
    public IActionResult Create(User NewUser)
    {
        if(ModelState.IsValid)
        {
            Console.WriteLine(NewUser.YourName);
            return RedirectToAction("NewUser", NewUser);
        } else {
            //render Validation Errors
            return View("Index");
        }
    }
    [HttpGet("NewUser")]
    public IActionResult NewUser(User NewUser)
    {
        return View("NewUser", NewUser);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
