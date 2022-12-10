using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class SaleItemSize
    {
        [Key]
        public int SaleItemSizeId { get; set; }

        [ForeignKey("SaleItem")]
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }

        public Size Size { get; set; }
    }
}
