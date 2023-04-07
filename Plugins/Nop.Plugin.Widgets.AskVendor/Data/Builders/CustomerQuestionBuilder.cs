using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Vendors;
using Nop.Data.Extensions;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Data.Builders;

public class CustomerQuestionBuilder : NopEntityBuilder<CustomerQuestion>
{
    public override void MapEntity(CreateTableExpressionBuilder table)
    {
        table.WithColumn(nameof(CustomerQuestion.VendorId)).AsInt32().ForeignKey<Vendor>()
            .WithColumn(nameof(CustomerQuestion.CustomerId)).AsInt32().ForeignKey<Customer>()
            .WithColumn(nameof(CustomerQuestion.ProductId)).AsInt32().ForeignKey<Product>()
            .WithColumn(nameof(CustomerQuestion.Question)).AsString().NotNullable()
            .WithColumn(nameof(CustomerQuestion.CreatedOnUtc)).AsDateTime2().NotNullable();
    }
}
