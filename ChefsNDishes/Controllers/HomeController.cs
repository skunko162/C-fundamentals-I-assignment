using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
     MyViewModel MyModel = new MyViewModel
        {
            AllChefs = _context.Chefs.ToList()

        };
        return View(MyModel);
    }


    [HttpPost("chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newChef);
            _context.SaveChanges();

            return RedirectToAction("Index");
        } else{
            MyViewModel MyModel = new MyViewModel
        {
            AllChefs = _context.Chefs.ToList()

        };
            return View("ChefNew", MyModel);
        }
    }

    [HttpGet("chefs/new")]
    public IActionResult ChefNew()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllChefs = _context.Chefs.ToList()

        };
        return View(MyModel);
    }

    [HttpGet("dishes/new")]
    public IActionResult DishNew()
    {

        ViewBag.AllChefs = _context.Chefs.ToList();
        return View("DishNew");
    }

    [HttpPost("dish/Create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();

            return RedirectToAction("DishesAll");
        } else{
            
            return DishNew();
        }
    }

    [HttpGet("dishes/all")]
    public IActionResult DishesAll()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllDishes = _context.Dishes.Include(x => x.Creator).ToList()

        };
        return View("DishesAll", MyModel);
    }


}
