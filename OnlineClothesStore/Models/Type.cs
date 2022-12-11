using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
