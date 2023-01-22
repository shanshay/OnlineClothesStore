using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Color
{
    public int ColorId { get; set; }

    public string ColorName { get; set; }

    public virtual ICollection<SaleItem> SaleItems { get; } = new List<SaleItem>();
}
