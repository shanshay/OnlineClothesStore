using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class SaleItemSize : BaseEntity
{
    public int? SizeId { get; set; }

    public virtual SaleItem SaleItem { get; set; }

    public virtual Size Size { get; set; }
}
