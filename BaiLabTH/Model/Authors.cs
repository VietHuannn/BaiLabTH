using System.ComponentModel.DataAnnotations;

namespace BaiLabTH.Model
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public List<Book_Author>? Book_Authors { get; set; }
    }
}
