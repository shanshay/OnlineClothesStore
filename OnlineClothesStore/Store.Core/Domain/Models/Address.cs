using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Address : BaseEntity
{
    public string Index { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string Area { get; set; }

    public string Street { get; set; }

    public string House { get; set; }

    public string Flat { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
