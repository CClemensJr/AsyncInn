using System.Collections.Generic;

namespace AsyncInn.Models
{
    public class Amenities
    {
        // Primary Key
        public int ID { get; set; }

        // Other properties
        public string Name { get; set; }

        // Navigational properties
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}