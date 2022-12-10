using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class SaleItemParameter
    {
        [Key]
        public int SaleItemParameterId { get; set; }

        [ForeignKey("SaleItem")]
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        [ForeignKey("Parameter")]
        public int ParameterId { get; set; }

        public Parameter Parameter { get; set; }
    }
}
