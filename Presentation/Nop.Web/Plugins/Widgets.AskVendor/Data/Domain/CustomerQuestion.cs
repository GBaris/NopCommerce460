using System;
using Nop.Core;

namespace Nop.Plugin.Widgets.AskVendor.Data.Domain;

public class CustomerQuestion : BaseEntity
{

    public int CustomerId { get; set; }
    public int VendorId { get; set; }
    public int ProductId { get; set; }
    public string Question { get; set; }
    public DateTime CreatedOnUtc  { get; set; } = DateTime.Now;

}
