using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class SaleItemPrice
{
    public int SaleItemPriceId { get; set; }

    public int? SaleItemId { get; set; }

    public int? PriceId { get; set; }

    public virtual Price Price { get; set; }

    public virtual SaleItem SaleItem { get; set; }
}
