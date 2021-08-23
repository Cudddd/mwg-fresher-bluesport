using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class BannerTypes
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<Banners> banners { get; set; }
    }
}