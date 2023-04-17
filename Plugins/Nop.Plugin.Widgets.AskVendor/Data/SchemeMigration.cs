using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Data;

[NopMigration("2023-04-17 09:46:10:5000000","Ask Vendor Installation Migrate2", MigrationProcessType.Installation)]
public class SchemeMigration : AutoReversingMigration
{
    public override void Up()
    {
        Create.TableFor<CustomerQuestion>();
    }
}
