using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using System.Linq;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; 

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        List<Dish> Alldishes = _context.Dishes.ToList();
        
        return View("Index", Alldishes);
    }
    [HttpGet("dishes/new")]
    public IActionResult Create()
    {
        return View("Create");
    }
    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            //Add the song to our db
            _context.Add(newDish);
            //Save the Changes
            _context.SaveChanges();
            //redirect somewhere
            return RedirectToAction("Index");
        } else 
        {
            return View("Create");
        }
    }
    [HttpGet("dishes/{id}")]
    public IActionResult ShowDish(int id)
    {
        Dish? OneDish = _context.Dishes.FirstOrDefault(a => a.DishId == id);
        return View("ViewOne", OneDish);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost("dishes/{DishId}/destroy")]
    public IActionResult DestroyDish(int DishId)
    {
        Dish? DishToDelete = _context.Dishes.SingleOrDefault(i => i.DishId == DishId);

        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet("dishes/{dishId}/edit")]
    public IActionResult EditDish(int dishId)
    {
        Dish? DishToEdit = _context.Dishes.FirstOrDefault(i => i.DishId == dishId);
        return View(DishToEdit);
    }

    [HttpPost("dishes/{DishId}/update")]
    public IActionResult UpdateDish(Dish newDish, int DishId)
    {
        if(ModelState.IsValid)
        {
            Dish? OldDish = _context.Dishes.FirstOrDefault(i => i.DishId == DishId);

            OldDish.Name = newDish.Name;
            OldDish.Chef = newDish.Chef;
            OldDish.Tastiness = newDish.Tastiness;
            OldDish.Calories = newDish.Calories;
            OldDish.Description = newDish.Description;
            OldDish.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            
            return RedirectToAction("Index");
        } else {
            return View("Edit", newDish);
        }
    }
}
