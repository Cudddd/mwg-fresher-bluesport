namespace Bluesport.Data.Entities
{
    public class Banners
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string alt { get; set; }
        public string typeId { get; set; }
        public string text { get; set; }
        public BannerTypes bannerType { get; set; }
    }
}