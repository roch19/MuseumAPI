using Microsoft.VisualBasic;

namespace MuseumAPI.Entities
{
    public class Exhibit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateAndTime YearOfCreation { get; set; }

        public int MuseumId { get; set; }
        public virtual Museum Museum {get; set; }
    }
}
