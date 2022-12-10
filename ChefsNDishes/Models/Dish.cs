#pragma warning disable CD8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
public class Dish
{
    [Key]
    public int DishId {get;set;}
    [Required(ErrorMessage = "Dish Name is required")]
    [MinLength(2)]
    public string NameOfDish {get;set;}
    [Range(1, int.MaxValue, ErrorMessage = "Number of calories must be greater than 0!")]
    public int NumOfCalories {get;set;}
    [Required(ErrorMessage = "A Tastiness rating is required")]
    [Range(1,5)]
    public int Tastiness {get;set;}
    public DateTime CreatedAt{get;set;}= DateTime.Now;
    public DateTime UptadedAt{get;set;}= DateTime.Now;

    public int ChefId {get;set;}
    // Navigation property:
    public Chef? Creator {get;set;}


}
// public class CaloriesReqAttribute : ValidationAttribute
// {
//     protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
//     {
//         if(((int)value) >= 0)
//         {
//             return new ValidationResult("The Value of calories must be greater than zero!");
//         } else {
//             return ValidationResult.Success;
//         }
//     }
// }