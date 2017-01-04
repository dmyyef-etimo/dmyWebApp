using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class AddCustomerBirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn(table: "dbo.Customers", name: "Birthday", columnAction: c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            DropColumn(table: "dbo.Customers", name: "Birthday");
        }
    }
}