using System;
using System.Collections.Generic;

namespace ePizza.Infrastructure.Entities;

public partial class CartItem
{
    public int Id { get; set; }

    public Guid CartId { get; set; }

    public int ItemId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
