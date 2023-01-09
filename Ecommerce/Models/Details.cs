using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Project.Models.Products;

public class Details
{
    [Key]
    public int id { get; set; }
    public string imageLink { get; set; }

    public int resolution { get; set; }
    public string zoomOptic { get; set; }
    public string video { get; set; }
    public bool stabilisator { get; set; }
    public int isoMax { get; set; }

    public int productTypeId { get; set; }
    [ForeignKey("productTypeId")]
    public Type productType { get; set; }

    public int productTechnoId { get; set; }
    [ForeignKey("productTechnoId")]
    public Techno productTechno { get; set; }

    public int productBrandId { get; set; }
    [ForeignKey("productBrandId")]
    public Brand productBrand { get; set; }

    public Details(int id, string imageLink, int resolution, string zoomOptic, string video, bool stabilisator, int isoMax, int productBrandId)
    {
        this.id = id;
        this.imageLink = imageLink;
        this.resolution = resolution;
        this.zoomOptic = zoomOptic;
        this.video = video;
        this.stabilisator = stabilisator;
        this.isoMax = isoMax;
        this.productBrandId = productBrandId;
    }
    public Details()
    {
    }

}

