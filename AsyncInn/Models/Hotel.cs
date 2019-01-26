using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        // Primary Key
        public int ID { get; set; }

        // Other properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // Navigation properies
        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
