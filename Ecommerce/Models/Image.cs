namespace E_Commerce_Project.Models.Products
{
    public class Image
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string title { get; set; }
        public IFormFile formFile { get; set; }

        public Image(){ }
        public Image(int id, string name, string title, IFormFile formFile)
        {
            this.id = id;
            this.name = name;
            this.title = title;
            this.formFile = formFile;
        }
    }
}
