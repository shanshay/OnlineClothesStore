using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Price
    {
        [Key]
        public int PriceId { get; set; }

        public DateTime DateSet { get; set; }

        public decimal PriceSize { get; set; }

        public SaleItem SaleItem { get; set; }

        public Currency Currency { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
