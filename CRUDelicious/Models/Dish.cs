#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;

public class Dish

{
    [Key]
    public int DishId {get;set;}
    [Required]
    [MinLength(2)]
    public string Name {get;set;}
    [Required]
    [MinLength(2)]
    public string Chef {get;set;}
    [Required]
    [Range(1,5)]
    public int Tastiness {get;set;}
    [Required]
    [Range (1,20000)]
    public int Calories {get;set;}
    [Required]
    public string Description {get;set;}
    public DateTime CreatedAt {get;set;}=DateTime.Now;
    public DateTime UpdatedAt {get;set;}=DateTime.Now;

}
