using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace My_Mane.Model
{
    [Table("CommercialRentLease")]
    public class CommercialRentLease
    {
        [Key]
        public int property_id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int? property_age { get; set; }
        public decimal? built_up_area { get; set; }
        public string PropertyOn { get; set; }
        public string StreetArea { get; set; }
        public decimal? expected_rent { get; set; }
        public decimal? expected_deposit { get; set; }
        public bool? rent_negotiable { get; set; }
        public bool? DepositNegotiable { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public int? lease_duration { get; set; }
        public string IdealFor { get; set; }
        public bool? power_backup { get; set; }
        public bool? Lift { get; set; }
        public int? Washrooms { get; set; }
        public bool? Parking { get; set; }
        public bool? Security { get; set; }
        public bool? water_storage { get; set; }
        public string Description { get; set; }
        public bool? PaintItAfterTenure { get; set; }
        public bool? clean_it_after_tenure { get; set; }

        public bool? clean_it_before_tenure { get; set; }
        [ForeignKey("property_id")]
        public Property Property { get; set; }
    }
}
