using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class SaleItemPrice : BaseEntity
{
    public int? SaleItemId { get; set; }

    public int? PriceId { get; set; }

    public virtual Price Price { get; set; }

    public virtual SaleItem SaleItem { get; set; }
}
