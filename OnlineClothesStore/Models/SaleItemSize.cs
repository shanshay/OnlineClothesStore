namespace OnlineClothesStore.Models
{
    public class SaleItemSize
    {
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        public int SizeId { get; set; }

        public Size Size { get; set; }
    }
}
