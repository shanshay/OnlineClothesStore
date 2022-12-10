using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Parameter
    {
        [Key]
        public int ParameterId { get; set; }

        public string Descr { get; set; }

        public decimal Size { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
