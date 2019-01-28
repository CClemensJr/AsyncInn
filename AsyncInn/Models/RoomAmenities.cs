using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        // Composite Keys
        [Key]
        [Column(Order = 1)]
        public int AmenitiesID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int RoomID { get; set; }

        // Navigational properties
        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}