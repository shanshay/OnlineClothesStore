using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    [Table("Prices")]
    public class Price
    {
        [Key]
        public int PriceId { get; set; }

        public DateTime DateSet { get; set; }

        public decimal PriceSize { get; set; }

        [ForeignKey("SaleItem")]
        public int SaleItemId { get; set; }

        public SaleItem SaleItem { get; set; }

        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }

        public Currency Currency { get; set; }

        [NotMapped]
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
