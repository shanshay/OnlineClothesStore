using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Login { get; set; }

    public string Email { get; set; }

    public int AddressId { get; set; }

    public virtual Address Address { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
