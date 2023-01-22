using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
