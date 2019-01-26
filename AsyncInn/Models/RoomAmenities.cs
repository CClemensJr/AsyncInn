namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        // Composite Keys
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }

        // Navigational properties
        public Amenities Amenities { get; set; }
        public Room Room { get; set; }
    }
}