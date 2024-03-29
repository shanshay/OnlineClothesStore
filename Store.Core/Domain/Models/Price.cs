﻿using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Price : BaseEntity
{
    public DateTime DateSet { get; set; }

    public decimal PriceSize { get; set; }

    public int SaleItemId { get; set; }

    public int CurrencyId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual Currency Currency { get; set; }

    public virtual SaleItem SaleItem { get; set; }

    public virtual ICollection<SaleItemPrice> SaleItemPrices { get; } = new List<SaleItemPrice>();
}
