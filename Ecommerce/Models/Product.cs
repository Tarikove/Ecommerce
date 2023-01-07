using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Project.Models.Products;

public class Product
{
    public static string addNewProductTitle { get; set; } = "Add New Product";
    [Key]
    public int id { get; set; }
    [Required]
    public string name { get; set; } = string.Empty;
    public double price { get; set; }
    public int productDetailsId { get; set; }
    [ForeignKey("productDetailsId")]
    public Details productDetails { get; set; }

    public int imageId { get; set; }
    public Image image { get; set; }
    public int remainingQty { get; set; }
    public int qtyOrdered { get; set; } = 0;
    public double totalPrice => qtyOrdered * price;

    public Product(int id, string name, double price, Details productDetails, Image image)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.productDetails = productDetails;
        this.image = image;
        //this.addNewProductTitle = "addNewProductTitle";
    }
    public Product()
    {

    }
}
