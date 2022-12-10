namespace OnlineClothesStore.Models
{
    public class SaleItemParameter
    {
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        public int ParameterId { get; set; }

        public Parameter Parameter { get; set; }
    }
}
