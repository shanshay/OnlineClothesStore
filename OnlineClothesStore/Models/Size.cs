using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    [Table("Sizes")]
    public class Size
    {
        [Key]
        public int SizeId { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
