using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
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
        [MaxLength(250)]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        // Navigation properies
        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
