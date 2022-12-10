namespace OnlineClothesStore.Models
{
    public class SaleItemPrice
    {
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        public int PriceId { get; set; }

        public Price Price { get; set; }
    }
}
