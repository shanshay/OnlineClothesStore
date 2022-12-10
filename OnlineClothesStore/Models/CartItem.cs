using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        public Cart Cart { get; set; }

        public SaleItem SaleItem { get; set; }

        public Size Size { get; set; }

        public int Count { get; set; }

        public Price Price { get; set; }
    }
}
