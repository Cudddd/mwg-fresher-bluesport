using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Categories
    {
        public string id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int level { get; set; }
        public string parentId { get; set; }
        public List<ProductMapCate> productMapCates { get; set; }
    }
}