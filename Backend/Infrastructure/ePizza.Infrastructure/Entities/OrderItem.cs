using System;
using System.Collections.Generic;

namespace ePizza.Infrastructure.Entities;

public partial class OrderItem
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public decimal Total { get; set; }

    public string OrderId { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
