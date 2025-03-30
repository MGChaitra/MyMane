using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace My_Mane.Model
{
    [Table("Property")]
    public class Property
    {
        [Key]
        public int property_id { get; set; }
        [Required]
       
        public int owner_id { get; set; }
        public DateTime created_at { get; set; } = DateTime.UtcNow;
        public DateTime updated_at { get; set; } = DateTime.UtcNow;
        public bool admin_approval { get; set; } = false;
        public string property_number { get; set; }

        [ForeignKey("owner_id")]
        public Owners Owner { get; set; }
    }
}
