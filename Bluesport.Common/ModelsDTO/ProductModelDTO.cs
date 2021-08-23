namespace Bluesport.Common.ModelsDTO
{
    public class ProductModelDTO
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
    }
}