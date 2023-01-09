using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Xml.Linq;

namespace Ecommerce.Models
{
    public class Client:IdentityUser 
    {
        
            public enum eCivility
            {
                Monsieur,
                Madame
            }

            [Required(ErrorMessage = "La civilité est obligatoire")]
            [Display(Name = "Civilité")]
            public eCivility civility { get; set; }
            [Required(ErrorMessage = "Le prénom est obligatoire")]
            [Display(Name = "Prénom")]
            public string firstName { get; set; }
            [Required(ErrorMessage = "Le nom de famille est obligatoire")]
            [Display(Name = "Nom de famille")]
            public string lastName { get; set; }
            public string fullName => firstName + " " + lastName;
            //[Required]
            //public int addressId { get; set; }
            //[ForeignKey("addressId")]
            //[NotMapped]
            //public Address address { get; set; }

            public Client() { }
        
    }
}
