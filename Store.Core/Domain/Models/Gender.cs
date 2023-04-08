using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Gender : BaseEntity
{
    public string ShortName { get; set; }

    public string Name { get; set; }

    public virtual ICollection<SaleItem> SaleItems { get; } = new List<SaleItem>();
}
