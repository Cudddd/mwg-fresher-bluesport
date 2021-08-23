using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Promotions
    {
        public string id { get; set; }
        public string name { get; set; }
        public string productId { get; set; }
        public Products product { get; set; }
        public List<PromotionDetails> promotionDetails { get; set; }
    }
}