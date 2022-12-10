#pragma warning disable CD8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChefsNDishes.Models;
public class Chef
{
    [Key]
    public int ChefId {get;set;}
    [Required]
    public string FirstName {get;set;}
    [Required]
    public string LastName {get;set;}
    [Required(ErrorMessage = "Date of birth is required")]
    [DateMinimumAge(18, ErrorMessage="must be at least {1} years of age")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public Nullable<System.DateTime> DateOfBirth {get;set;}
    public DateTime CreatedAt{get;set;}= DateTime.Now;
    public DateTime UptadedAt{get;set;}= DateTime.Now;

    //Navigation property
    public List<Dish> CreatedDishes {get;set;} = new List<Dish>();

    [NotMapped]
    public int Age
    {
        get
        {
            DateTime now = DateTime.Today;
            int age = now.Year - DateOfBirth.Value.Year;
            if (DateOfBirth > now.AddYears(-age)) age--;
                return age;
        }
    }
}
public class DateMinimumAgeAttribute : ValidationAttribute
{
    public DateMinimumAgeAttribute(int minimumAge)
    {
        MinimumAge = minimumAge;
        ErrorMessage = "{0} must be someone at least {1} years of age";
    }

    public override bool IsValid(object value)
    {
        DateTime date;
        if ((value != null && DateTime.TryParse(value.ToString(), out date)))
        {
            return date.AddYears(MinimumAge) < DateTime.Now;
        }

        return false;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(ErrorMessageString, name, MinimumAge);
    }

    public int MinimumAge { get; }
}