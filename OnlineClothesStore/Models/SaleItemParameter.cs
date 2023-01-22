using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class SaleItemParameter
{
    public int SaleItemParameterId { get; set; }

    public int? SaleItemId { get; set; }

    public int? ParameterId { get; set; }

    public virtual Parameter Parameter { get; set; }

    public virtual SaleItem SaleItem { get; set; }
}
