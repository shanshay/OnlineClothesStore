using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class SaleItem
{
    public int Id { get; set; }

    public string ShortName { get; set; }

    public string FullName { get; set; }

    public string Description { get; set; }

    public int Count { get; set; }

    public int ColorId { get; set; }

    public int GenderId { get; set; }

    public int? TypeId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual Color Color { get; set; }

    public virtual Gender Gender { get; set; }

    public virtual ICollection<Price> Prices { get; } = new List<Price>();

    public virtual ICollection<SaleItemParameter> SaleItemParameters { get; } = new List<SaleItemParameter>();

    public virtual ICollection<SaleItemPrice> SaleItemPrices { get; } = new List<SaleItemPrice>();

    public virtual ICollection<SaleItemSize> SaleItemSizes { get; } = new List<SaleItemSize>();

    public virtual Type Type { get; set; }
}
