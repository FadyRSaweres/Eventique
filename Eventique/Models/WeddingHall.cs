using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eventique.Models
{
    public class WeddingHall
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Hall_Price { get; set; }
        public string Offers { get; set; }
        public List<Review> HallsReview { get; set; }
        public int Capacity { get; set; }
        public string OtherServices { get; set; }
        public string HallType { get; set; }
        public List<AvailableDate> AvailbleDates { get; set; }
        public Album Album { get; set; }
        public List<WeddingHallsRequest> HotelRequest { get; set; }
    }
}
