using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class MembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    name: "dbo.MembershipTypes",
                    columnsAction: c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false)
                    })
                .PrimaryKey(t => t.Id);

            AddColumn(table: "dbo.Customers", name: "MembershipTypeId", columnAction: c => c.Byte(nullable: false));
            CreateIndex(table: "dbo.Customers", column: "MembershipTypeId");
            AddForeignKey(dependentTable: "dbo.Customers", dependentColumn: "MembershipTypeId",
                principalTable: "dbo.MembershipTypes", principalColumn: "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey(dependentTable: "dbo.Customers", dependentColumn: "MembershipTypeId",
                principalTable: "dbo.MembershipTypes");
            DropIndex(table: "dbo.Customers", columns: new[] {"MembershipTypeId"});
            DropColumn(table: "dbo.Customers", name: "MembershipTypeId");
            DropTable(name: "dbo.MembershipTypes");
        }
    }
}