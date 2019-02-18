using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        // Composite Keys
        // [Key]
        // [Column(Order=1)]
        [Required]
        [Display(Name = "Hotel Location: ")]
        public int HotelID { get; set; }

        //[Key]
        //[Column(Order=2)]
        [Required]
        [Display(Name = "Room Number: ")]
        public int RoomNumber { get; set; }

        // Foreign Key
        //[ForeignKey("Room")]
        public int RoomID { get; set; }

        // Other properties
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Rate per Night: ")]
        public decimal Rate { get; set; }

        [Display(Name = "Pet Friendly Room: ")]
        public byte PetFriendly { get; set; }

        // Navigation properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}