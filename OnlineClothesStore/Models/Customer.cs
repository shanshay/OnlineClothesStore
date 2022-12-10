using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public User User { get; set; }

        public int CartId { get; set; }

        public Cart Cart { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
