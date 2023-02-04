using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Currency : BaseEntity
{
    public int CurrencyNumber { get; set; }

    public string CurrencyName { get; set; }

    public string ShortCurrencyName { get; set; }

    public virtual ICollection<Price> Prices { get; } = new List<Price>();
}
