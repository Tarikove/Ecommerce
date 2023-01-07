using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Project.Models.Products;

public class Brand
{
    [Key]
    public int id { get; set; }
    [Required]
    public string name { get; set; }

    public Brand(int id, string name) 
    {
        this.id = id;
        this.name = name;
    }
    public Brand() { }
}
