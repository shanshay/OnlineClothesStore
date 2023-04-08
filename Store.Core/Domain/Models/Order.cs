using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class Order : BaseEntity
{
    public string OrderNumber { get; set; }

    public int StatusId { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual Status Status { get; set; }
}
