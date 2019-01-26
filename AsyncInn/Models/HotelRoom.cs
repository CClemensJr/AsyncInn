namespace AsyncInn.Models
{
    public class HotelRoom
    {
        // Composite Keys
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }

        // Foreign Key
        public decimal RoomID { get; set; }

        // Other properties
        public decimal Rate { get; set; }
        public byte PetFriendly { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}