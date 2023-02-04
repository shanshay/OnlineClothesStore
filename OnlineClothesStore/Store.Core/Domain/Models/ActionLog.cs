using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Store.Core.Domain.Models;

public partial class ActionLog : BaseEntity
{
    public int CustomerId { get; set; }

    public DateTime Date { get; set; }

    public string ActionDescription { get; set; }

    public virtual Customer Customer { get; set; }
}
