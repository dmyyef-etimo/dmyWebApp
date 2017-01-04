using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class IsSubscribedToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn(table: "dbo.Customers", name: "IsSubscribedToNewsLetter",
                columnAction: c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn(table: "dbo.Customers", name: "IsSubscribedToNewsLetter");
        }
    }
}