using System;
using System.Collections.Generic;

namespace ePizza.Infrastructure.Entities;

public partial class Order
{
    public string Id { get; set; } = null!;

    public string PaymentId { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Locality { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual User User { get; set; } = null!;
}
