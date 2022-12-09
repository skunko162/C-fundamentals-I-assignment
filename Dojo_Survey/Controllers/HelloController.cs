using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class HelloController : Controller
{
    //Routing!!
    //this tells our controller we have a page we want to see (or GET)
    [HttpGet]
    //what is the URL
    // this goes to localhost:5xxx/
    [Route("/")]
    public ViewResult Index ()
    {
        //Veiwbag allows us to pass datat from our controller to our view
        //Think of a veiwbag as a dictionary it has keys and values
        ViewBag.Name = "Steve";
        return View("Index");
    }
     
    [HttpGet("user/{id}")]
    public string OneUser(int id)
    {
        return $"This is user {id}";
    }

    [HttpPost("AUser")]
    public IActionResult Process(string YourName, string DojoLocation, string FavoriteLanguage, string Comments)

    {
        ViewBag.YourName = YourName;
        ViewBag.DojoLocation = DojoLocation;
        ViewBag.FavoriteLanguage = FavoriteLanguage;
        ViewBag.Comments = Comments;
        return View("AUser");
    }
}