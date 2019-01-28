using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        // Composite Keys
        [Key]
        [Column(Order=1)]
        public int HotelID { get; set; }

        [Key]
        [Column(Order=2)]
        public int RoomNumber { get; set; }

        // Foreign Key
        [ForeignKey("Room")]
        public int RoomID { get; set; }

        // Other properties
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rate { get; set; }
        public byte PetFriendly { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}