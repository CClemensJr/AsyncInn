using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class Amenities
    {
        // Primary Key
        [Key]
        public int ID { get; set; }

        // Other properties
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        // Navigational properties
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}