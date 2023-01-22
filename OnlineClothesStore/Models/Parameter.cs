using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Parameter
{
    public int ParameterId { get; set; }

    public string Descr { get; set; }

    public decimal Size { get; set; }

    public virtual ICollection<SaleItemParameter> SaleItemParameters { get; } = new List<SaleItemParameter>();
}
