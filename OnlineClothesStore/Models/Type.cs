using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Type
{
    public int TypeId { get; set; }

    public string TypeName { get; set; }

    public virtual ICollection<SaleItem> SaleItems { get; } = new List<SaleItem>();
}
