using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        public Customer Customer { get; set; }

        public User User { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}
