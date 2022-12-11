using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    [Table("SaleItems")]
    public class SaleItem
    {
        [Key]        
        public int Id { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        [ForeignKey("Color")]
        public int ColorId { get; set; }

        public Color Color { get; set; }


        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }

        [ForeignKey("Type")]
        public Type TypeId { get; set; }

        public Type Type { get; set; }
      
        public ICollection<Size> Sizes { get; set; }
     
        public ICollection <Parameter> Parameters { get; set; }
    
        public ICollection <Price> Prices { get; set; }
    }
}
