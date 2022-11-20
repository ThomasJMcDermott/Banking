using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace s3851480_a3.Models;

public class Addresses  
{

    public int AddressesID { get; set; }
    public int ContactID { get; set; }
    public virtual Contacts Contact { get; set; }

    [StringLength(100)]
    public string Street { get; set; }
    
    [StringLength(100), RegularExpression(@"^[A-Z]+[a-zA-Z ]*$", ErrorMessage = "Invalid format, Must start with an upper-case letter and only contain letters.")]
    public string Suburb { get; set; }

    [RegularExpression(@"^\d{4}$")]
    public string PostCode { get; set; }

    [StringLength(3), RegularExpression(@"\b(ACT|NSW|NT|QLD|SA|TAS|VIC|WA)\b", ErrorMessage = "Must be a valid Australian State")]
    public string State { get; set; }

}
