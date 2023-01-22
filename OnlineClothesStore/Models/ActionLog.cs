using System;
using System.Collections.Generic;

namespace OnlineClothesStore.Models;

public partial class ActionLog
{
    public int LogId { get; set; }

    public int CustomerId { get; set; }

    public DateTime Date { get; set; }

    public string ActionDescription { get; set; }

    public virtual Customer Customer { get; set; }
}
