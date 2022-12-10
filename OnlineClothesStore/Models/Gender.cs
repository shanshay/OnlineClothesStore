using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Gender
    {
        [Key]
        public int  SexId {get; set;}

        public string ShortName { get; set; }

        public string Name { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
