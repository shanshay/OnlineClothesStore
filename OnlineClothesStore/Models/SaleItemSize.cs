using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class SaleItemSize
{
    public int SaleItemSizeId { get; set; }

    public int? SaleItemId { get; set; }

    public int? SizeId { get; set; }

    public virtual SaleItem SaleItem { get; set; }

    public virtual Size Size { get; set; }
}
