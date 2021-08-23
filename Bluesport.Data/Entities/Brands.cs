using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Brands
    {
        public string id { get; set; }
        public string name { get; set; }
        public string info { get; set; }
        public string image { get; set; }
        public List<Products> products { get; set; }
    }
}