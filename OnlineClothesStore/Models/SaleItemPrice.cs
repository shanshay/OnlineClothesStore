using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class SaleItemPrice
    {
        [Key]
        public int SaleItemPriceId { get; set; }

        [ForeignKey("SaleItem")]
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        [ForeignKey("Price")]
        public int PriceId { get; set; }

        public Price Price { get; set; }
    }
}
