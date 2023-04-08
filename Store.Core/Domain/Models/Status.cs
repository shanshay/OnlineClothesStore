using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Status : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
