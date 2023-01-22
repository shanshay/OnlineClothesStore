using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string ShortName { get; set; }

    public string Name { get; set; }

    public virtual ICollection<SaleItem> SaleItems { get; } = new List<SaleItem>();
}
