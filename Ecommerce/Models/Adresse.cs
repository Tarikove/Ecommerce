using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ecommerce.Models
{
    public class Adresse
    {
        // read/write (get/set) properties
        public Guid Id { get; set; }

        [Display(Name = "Numéro")]
        [MaxLength(15)]
        public string Num { get; set; }

        
        [Display(Name = "Rue")]
        [MaxLength(70)]
        public string Road { get; set; }
        
        [Display(Name = "Complément")]
        [MaxLength(70)]
        public string? Complement { get; set; }
        
        [Display(Name = "Code postal")]
        [MaxLength(5)]
        public string ZipCode { get; set; }
        
        [Display(Name = "Ville")]
        [MaxLength(30)]
        public string City { get; set; }


        // calculated properties
        [Display(Name = "Adresse complète")]
        public string? FullAddress => $"{Road} - {Complement} {ZipCode} {City}";
        
        public virtual ICollection<Client> Clients { get; set; }


      
    }
}
