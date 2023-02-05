using System.Collections.Generic;

namespace MuseumAPI.Entities
{
    public class Museum
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string Category { get; set; }
        
        public bool FreeEntry { get; set; }
        
        public string ContactEmail { get; set; }
        
        public string ContactNumber { get; set; }

        public int AddressId { get; set; }

        public virtual Address Adress { get; set; }

        public virtual List<Exhibit> Exhibits{get; set ;}
    }
}
