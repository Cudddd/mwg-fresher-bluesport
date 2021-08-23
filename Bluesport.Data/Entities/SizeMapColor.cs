namespace Bluesport.Data.Entities
{
    public class SizeMapColor
    {
        public string sizeId { get; set; }
        public string colorId { get; set; }
        public int quantity { get; set; }
        public Sizes size { get; set; }
        public Colors color { get; set; }
    }
}