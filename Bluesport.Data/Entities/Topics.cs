using System.Collections.Generic;

namespace Bluesport.Data.Entities
{
    public class Topics
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<Contacts> contacts { get; set; }
    }
}