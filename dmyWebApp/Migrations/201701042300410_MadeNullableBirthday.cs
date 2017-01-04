using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class MadeNullableBirthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn(table: "dbo.Customers", name: "Birthday", columnAction: c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn(table: "dbo.Customers", name: "Birthday", columnAction: c => c.DateTime(nullable: false));
        }
    }
}