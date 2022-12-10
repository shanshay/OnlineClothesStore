using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public User User { get; set; }


        [ForeignKey("Cart")]
        public int CartId { get; set; }        

        public Cart Cart { get; set; }
       
        public ICollection<Order> Orders { get; set; }
    }
}
