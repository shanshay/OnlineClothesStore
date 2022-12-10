using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }

        public string Name { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
