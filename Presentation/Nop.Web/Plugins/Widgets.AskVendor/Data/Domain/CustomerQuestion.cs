using System;
using Nop.Core;

namespace Nop.Plugin.Widgets.AskVendor.Data.Domain;

public class CustomerQuestion : BaseEntity
{

    public int CustomerId { get; set; }
    public int VendorId { get; set; }
    public int ProductId { get; set; }
    public string Subject { get; set; }
    public string Question { get; set; }
    public DateTime QuestionDate  { get; set; } = DateTime.Now;
    public string Answer { get; set; }
    public DateTime AnswerDate { get; set; }
    public bool IsReadByVendor { get; set; } = false;
    public bool IsReadByCustomer { get; set; } = false;
    public bool IsAnswered { get; set; } = false;
    public bool IsDeletedByCustomer { get; set; } = false;
    public bool IsDeletedByVendor { get; set; } = false;
}
