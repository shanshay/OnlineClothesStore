using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Color : BaseEntity
{
    public string ColorName { get; set; }

    public virtual ICollection<SaleItem> SaleItems { get; } = new List<SaleItem>();
}
