using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Products
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public decimal priceCurrent { get; set; }
        public decimal priceOld { get; set; }
        public int saleOff { get; set; }
        public string description { get; set; }
        public string brandId { get; set; }
        public bool soldOut { get; set; }
        public int installment { get; set; }
        public Brands brand { get; set; }
        public List<ProductImages> productImgaes { get; set; }
        public List<ProductDetails> productDetails { get; set; }
        public List<Promotions> promotions { get; set; }
        public List<ProductMapCate> productMapCates { get; set; }
        public List<ProductMapSize> productMapsizes { get; set; }
    }
}