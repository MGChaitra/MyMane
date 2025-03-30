using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace My_Mane.Model
{
    [Table("HouseRent")]
    public class HouseRent
    {
        [Key]
        public int property_id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string BhkType { get; set; }
        public string Facing { get; set; }
        public decimal? built_up_area { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public DateTime? available_from { get; set; }
        public decimal? expected_rent { get; set; }
        public decimal? expected_deposit { get; set; }
        public bool rent_negotiable { get; set; }
        public string PreferredTenants { get; set; }
        public string Furnishing { get; set; }
        public bool Parking { get; set; }
        public string Description { get; set; }
        public int? Bathrooms { get; set; }
        public bool NonVegAllowed { get; set; }

        [ForeignKey("property_id")]
        public Property Property { get; set; }
    }
}
