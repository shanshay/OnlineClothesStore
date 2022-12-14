using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    public class Gender
    {
        [Key]
        public int  GenderId {get; set;}

        public string ShortName { get; set; }

        public string Name { get; set; }
      
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
