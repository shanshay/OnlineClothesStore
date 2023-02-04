using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class SaleItemParameter : BaseEntity
{
    public int? SaleItemId { get; set; }

    public int? ParameterId { get; set; }

    public virtual Parameter Parameter { get; set; }

    public virtual SaleItem SaleItem { get; set; }
}
