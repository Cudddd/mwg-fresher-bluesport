using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Sizes
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<ProductMapSize> productMapSizes { get; set; }
        public List<SizeMapColor> sizeMapColors { get; set; }
    }
}