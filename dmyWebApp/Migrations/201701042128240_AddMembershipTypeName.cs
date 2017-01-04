using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class AddMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn(table: "dbo.MembershipTypes", name: "Name",
                columnAction: c => c.String(nullable: false, maxLength: 20));
        }

        public override void Down()
        {
            DropColumn(table: "dbo.MembershipTypes", name: "Name");
        }
    }
}