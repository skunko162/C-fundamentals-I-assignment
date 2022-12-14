using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProductAndCategories.Models;

namespace ProductAndCategories.Controllers;

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
    public IActionResult Products()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllProducts = _context.Products.ToList()
        };
        return View("Products", MyModel);
    }

    [HttpPost("product/create")]
    public IActionResult CreateProduct(Product newProduct)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
            return RedirectToAction("Products");
        }else{
            return Products();
        }
    }
    [HttpGet("categories")]
    public IActionResult Categories()
    {
        MyViewModel MyModel = new MyViewModel
        {
            AllCategories = _context.Categories.ToList()
        };
        return View("Categories", MyModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost("category/create")]
    public IActionResult CreateCategory(Category newCategory)
    {
        if(ModelState.IsValid){
            _context.Add(newCategory);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        } else {
            return Categories();
        }
    }

    [HttpGet("products/{productId}")]
    public IActionResult ViewProduct(int productId)
    {
        ViewBag.AllCategories = _context.Categories
                                                    .Include(a => a.Associations)
                                                    .Where(a => a.Associations
                                                    .All(b => b.ProductId != productId)).ToList();
        Product? TheProduct = _context.Products
                                                    .Include(a => a.Associations)
                                                    .ThenInclude(a => a.Category)
                                                    .FirstOrDefault(p => p.ProductId == productId);
    Association? TheAssociation = new Association();
    TheAssociation.ProductId = TheProduct.ProductId;
    ShowProductViewModel MyModel = new ShowProductViewModel
    
    {
        Product = TheProduct,
        Attributes = _context.Associations  
                                                .Include(a => a.Category)
                                                .Where(a => a.ProductId == productId).ToList(),
        Association =TheAssociation
    
    };
    return View("ViewProduct", MyModel);
    }

[HttpGet("categories/{categoryId}")]
    public IActionResult ViewCategory(int categoryId)
    {
        ViewBag.AllProducts = _context.Products
                                                .Include(a => a.Associations)
                                                .Where(a => a.Associations
                                                .All(b => b.CategoryId != categoryId)).ToList();
        Category? TheCategory = _context.Categories
                                                .Include(a => a.Associations)
                                                .ThenInclude(a => a.Product)
                                                .FirstOrDefault(c => c.CategoryId == categoryId);
        Association? TheAssociation = new Association();
        TheAssociation.CategoryId = TheCategory.CategoryId;
        ShowCategoryViewModel MyModel = new ShowCategoryViewModel
        {
            Category = TheCategory,
            Attributes = _context.Associations
                                                    .Include(a => a.Product)
                                                    .Where(a => a.CategoryId == categoryId).ToList(),
            Association = TheAssociation
        };
        return View("ViewCategory", MyModel);

    }
    [HttpGet("Association/new")]
    public IActionResult AddAssociation()
    {
        ViewBag.AllProducts = _context.Products.OrderBy(p =>p.Name).ToList();
        ViewBag.AllCategories = _context.Categories.OrderBy(c => c.Name).ToList();
        return View("_AddAssociation");
    }

    [HttpPost("Associations/create")]
    public IActionResult CreateAssociation(Association newAssociation)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newAssociation);
            _context.SaveChanges();
            return RedirectToAction("ViewProduct", new {productId = newAssociation.ProductId});
        } else {
            return View("products", newAssociation.ProductId);
        }
    }
    [HttpPost("associations/{AssociationId}destroy")]
    public IActionResult DestroyAssociation(int AssociationId)
    {
        Association? AssToDelete = _context.Associations.SingleOrDefault(a => a.AssociationId==AssociationId);
        
        _context.Associations.Remove(AssToDelete);
        _context.SaveChanges();

        return RedirectToAction("DestroyAssociation");

    }
    [HttpGet("DestroyAssociation")]
    public IActionResult DeletedView()
    {
        return View ("DestroyAssociation");
    }
}