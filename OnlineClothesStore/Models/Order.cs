using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string OrderNumber { get; set; }

    public int StatusId { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual Status Status { get; set; }
}
