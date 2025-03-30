using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Mane.Model
{
    [Table("Blogs")]
    public class Blogs
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? publish_date { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
    }
}
