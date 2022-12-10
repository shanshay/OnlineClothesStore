using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineClothesStore.Models
{
    [Table("Parameters")]
    public class Parameter
    {
        [Key]
        public int ParameterId { get; set; }

        public string Descr { get; set; }

        public decimal Size { get; set; }

        [NotMapped]
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}
