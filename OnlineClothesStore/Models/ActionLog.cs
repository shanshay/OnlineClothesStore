using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class ActionLog
    {
        [Key]
        public int LogId { get; set; }

        public Customer Customer { get; set; }

        public DateTime Date { get; set; }

        public string ActionDescription { get; set; }

    }
}
