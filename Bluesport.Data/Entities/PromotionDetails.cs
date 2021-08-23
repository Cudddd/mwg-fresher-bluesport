namespace Bluesport.Data.Entities
{
    public class PromotionDetails
    {
        public string id { get; set; }
        public string info { get; set; }
        public bool online { get; set; }
        public bool more { get; set; }
        public string promotionId { get; set; }
        public Promotions promotion { get; set; }
    }
}