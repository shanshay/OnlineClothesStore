using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public string OrderNumber { get; set; }        

        public Status Status { get; set; }

        public Customer Customer { get; set; }
    }
}
