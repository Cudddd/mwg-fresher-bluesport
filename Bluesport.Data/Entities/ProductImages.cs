namespace Bluesport.Data.Entities
{
    public class ProductImages
    {
        public string id { get; set; }
        public string productId { get; set; }
        public string path { get; set; }
        public string alt { get; set; }
        public bool avatar { get; set; }
        public Products product { get; set; }
    }
}