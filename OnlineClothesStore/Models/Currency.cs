using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }

        public int CurrencyNumber { get; set; }

        public string CurrencyName { get; set; }

        public string ShortCurrencyName { get; set; }
    }
}
