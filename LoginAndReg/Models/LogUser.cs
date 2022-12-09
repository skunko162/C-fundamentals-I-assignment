#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LoginAndReg.Models;
public class LogUser
{
    [Required(ErrorMessage = "The Email field is required")]
    [EmailAddress]
    public string LEmail {get;set;}
    [Required (ErrorMessage = "The Password field is required")]
    [DataType(DataType.Password)]
    public string LPassword{get;set;}
}

