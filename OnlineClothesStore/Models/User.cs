using System.ComponentModel.DataAnnotations;

namespace OnlineClothesStore.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Home { get; set; }

        public Address Address { get; set; }
    }
}
