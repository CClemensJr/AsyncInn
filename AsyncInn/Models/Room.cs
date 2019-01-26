using System.Collections.Generic;

namespace AsyncInn.Models
{
    public class Room
    {
        // Primary Key
        public int ID { get; set; }

        // Other properties
        public string Name { get; set; }
        public int Layout { get; set; }

        // Navigation properties
        public ICollection<HotelRoom> HotelRooms { get; set; }
        public ICollection<RoomAmenities> RoomAmenities { get; set;}
    }

    public enum Layout
    {
        Studio = 0,
        OneBedroom = 1,
        TwoBedroom = 2
    }
}