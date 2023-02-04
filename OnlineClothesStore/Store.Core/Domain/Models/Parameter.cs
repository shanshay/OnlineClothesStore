using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Parameter : BaseEntity
{
    public string Descr { get; set; }

    public decimal Size { get; set; }

    public virtual ICollection<SaleItemParameter> SaleItemParameters { get; } = new List<SaleItemParameter>();
}
