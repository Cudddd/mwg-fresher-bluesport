namespace Bluesport.Data.Entities
{
    public class ProductMapCate
    {
        public string productId { get; set; }
        public string cateId { get; set; }
        public Products product { get; set; }
        public Categories category { get; set; }
    }
}