using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace s3851480_a3.Models;

public class Contacts
{
    public int ContactID { get; set; }

    [Display(Name = "First name")]
    [StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid format, Must start with an upper-case letter and only contain letters.")]
    public string FirstName { get; set; }

    [Display(Name = "Last name")]
    [StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid format, Must start with an upper-case letter and only contain letters.")]
    public string LastName { get; set; }

    [Display(Name = "Email address")]
    [Required(ErrorMessage = "The email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Display(Name = "Mobile Phone")]
    [StringLength(10), RegularExpression(@"^04\d{2}\d{3}\d{3}$")]
    public string? Mobile { get; set; }
    public virtual Addresses? HomeAddressID { get; set; }
    public virtual Addresses? WorkAddressID { get; set; }

}
