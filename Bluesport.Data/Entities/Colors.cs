using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Colors
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<SizeMapColor> sizeMapColors { get; set; }
    }
}