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
            .WithColumn(nameof(CustomerQuestion.Subject)).AsString().NotNullable()
            .WithColumn(nameof(CustomerQuestion.Question)).AsString().NotNullable()
            .WithColumn(nameof(CustomerQuestion.QuestionDate)).AsDateTime2().NotNullable()
            .WithColumn(nameof(CustomerQuestion.Answer)).AsString().Nullable()
            .WithColumn(nameof(CustomerQuestion.AnswerDate)).AsDateTime2().Nullable()
            .WithColumn(nameof(CustomerQuestion.IsReadByVendor)).AsBoolean().NotNullable()
            .WithColumn(nameof(CustomerQuestion.IsReadByCustomer)).AsBoolean().NotNullable()
            .WithColumn(nameof(CustomerQuestion.IsAnswered)).AsBoolean().NotNullable()
            .WithColumn(nameof(CustomerQuestion.IsDeletedByCustomer)).AsBoolean().NotNullable()
            .WithColumn(nameof(CustomerQuestion.IsDeletedByVendor)).AsBoolean().NotNullable();
    }
}
