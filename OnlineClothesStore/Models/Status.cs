using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}
