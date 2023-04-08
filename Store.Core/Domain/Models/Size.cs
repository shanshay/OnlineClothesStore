using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Size : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual ICollection<SaleItemSize> SaleItemSizes { get; } = new List<SaleItemSize>();
}
