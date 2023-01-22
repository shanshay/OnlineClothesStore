using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Size
{
    public int SizeId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual ICollection<SaleItemSize> SaleItemSizes { get; } = new List<SaleItemSize>();
}
