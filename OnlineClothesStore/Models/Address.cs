using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class Address
    {
        public int AddressId { get; set; }        

        public string Index { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Area { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Flat { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
