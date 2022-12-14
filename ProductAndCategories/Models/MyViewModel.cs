#pragma warning disable CS8618

namespace ProductAndCategories.Models;
public class MyViewModel
{
    
    public Product Product {get;set;}
    public List<Product> AllProducts {get;set;}
    public Category Category {get;set;}
    public List<Category> AllCategories {get;set;}
    public Association Attributes {get;set;}

}