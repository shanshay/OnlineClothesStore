using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class SaleItem
    {
        [Key]        
        public int Id { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }      

        public Color Color { get; set; }

        public Gender Gender { get; set; }

        public ICollection<Size> Sizes { get; set; }

        public ICollection <Parameter> Parameters { get; set; }

        public ICollection <Price> Prices { get; set; }
    }
}
