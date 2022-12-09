#pragma warning disable
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey_Validations.Models;

public class User
{
    [Required]
    public string YourName {get;set;}
    [Required]
    public string DojoLocation {get;set;}
    [Required]
    public string FavoriteLang {get;set;}
    public string? Comments {get;set;}

}