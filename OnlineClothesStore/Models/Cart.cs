using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int CustomerId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual Customer Customer { get; set; }
}
