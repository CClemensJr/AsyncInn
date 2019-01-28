using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class Room
    {
        // Primary Key
        [Key]
        public int ID { get; set; }

        // Other properties
        [Required]
        [MaxLength(250)]
        [MinLength(6)]
        public string Name { get; set; }

        [Required]
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