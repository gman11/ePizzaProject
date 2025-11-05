using System;
using System.Collections.Generic;

namespace ePizza.Infrastructure.Entities;

public partial class PaymentDetail
{
    public string Id { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public decimal Tax { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Total { get; set; }

    public string Email { get; set; } = null!;

    public string Status { get; set; } = null!;

    public Guid CartId { get; set; }

    public decimal GrandTotal { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UserId { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
