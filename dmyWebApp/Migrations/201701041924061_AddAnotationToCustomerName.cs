using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class AddAnotationToCustomerName : DbMigration
    {
        public override void Up()
        {
            AlterColumn(table: "dbo.Customers", name: "Name",
                columnAction: c => c.String(nullable: false, maxLength: 255));
        }

        public override void Down()
        {
            AlterColumn(table: "dbo.Customers", name: "Name", columnAction: c => c.String());
        }
    }
}