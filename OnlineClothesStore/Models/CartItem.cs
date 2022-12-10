using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }


        [ForeignKey("Cart")]
        public int CartId { get; set; }

        public Cart Cart { get; set; }

        [ForeignKey("SaleItem")]
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }

        public Size Size { get; set; }

        public int Count { get; set; }

        [ForeignKey("Price")]
        public int PriceId { get; set; }

        public Price Price { get; set; }
    }
}
