using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public int CurrencyNumber { get; set; }

    public string CurrencyName { get; set; }

    public string ShortCurrencyName { get; set; }

    public virtual ICollection<Price> Prices { get; } = new List<Price>();
}
