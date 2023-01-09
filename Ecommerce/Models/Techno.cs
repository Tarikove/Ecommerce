using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Project.Models.Products;

public class Techno
{
    [Key]
    public int id { get; set; }
    [Required]
    public string name { get; set; }

    public string description { get; set; }

    public Techno (int id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
    }
    public Techno() { }
}
