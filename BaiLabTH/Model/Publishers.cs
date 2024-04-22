using System.ComponentModel.DataAnnotations;

namespace BaiLabTH.Model
{
    public class Publishers
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        // One-to-many relation with author
        public List<Book>? Book { get; set; }
    }
}
