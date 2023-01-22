using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int CartId { get; set; }

    public int SaleItemId { get; set; }

    public int SizeId { get; set; }

    public int Count { get; set; }

    public int PriceId { get; set; }

    public virtual Cart Cart { get; set; }

    public virtual Price Price { get; set; }

    public virtual SaleItem SaleItem { get; set; }

    public virtual Size Size { get; set; }
}
