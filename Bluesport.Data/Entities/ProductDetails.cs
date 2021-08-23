using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class ProductDetails
    {
        public string id { get; set; }
        public string productId { get; set; }
        public Dictionary<string,string> detail { get; set; }
        public Products product { get; set; }
    }
}