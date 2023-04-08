using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Customer : BaseEntity
{
    public int? UserId { get; set; }

    public virtual ICollection<ActionLog> ActionLogs { get; } = new List<ActionLog>();

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual User User { get; set; }
}
