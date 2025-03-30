using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace My_Mane.Model
{
    [Table("PG")]
    public class PG
    {
        [Key]
        public int property_id { get; set; }
        public string Name { get; set; }
        public string bedding_details { get; set; }
        public decimal? ExpectedRent { get; set; }
        public decimal? ExpectedDeposit { get; set; }
        public string RoomAmenities { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string landmark_street { get; set; }
        public string AvailableFor { get; set; }
        public string preferred_guests { get; set; }
        public DateTime? available_from { get; set; }
        public bool? food_included { get; set; }
        public TimeSpan? GateClosingTime { get; set; }
        public string pg_hostel_rules { get; set; }
        public string Description { get; set; }
        public string available_services { get; set; }
        public string AvailableAmenities { get; set; }
        public bool? Parking { get; set; }
        public bool? Security { get; set; }

        [ForeignKey("property_id")]  
        public Property Property { get; set; }
    }
}
