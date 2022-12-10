using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        public string ColorName { get; set; }
       
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
