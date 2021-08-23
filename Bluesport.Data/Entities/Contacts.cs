namespace Bluesport.Data.Entities
{
    public class Contacts
    {
        public string id { get; set; }
        public string topicId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string cusName { get; set; }
        public string cusEmail { get; set; }
        public string cusPhone { get; set; }
        public Topics topic { get; set; }
    }
}