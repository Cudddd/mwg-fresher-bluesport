namespace Bluesport.Data.Entities
{
    public class ProductMapSize
    {
        public string productId { get; set; }
        public string sizeId { get; set; }
        public Products product { get; set; }
        public Sizes size { get; set; }
    }
}