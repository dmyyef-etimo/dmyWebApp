using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql(sql: "insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) values (1, 0, 0, 0)");
            Sql(sql: "insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) values (2, 30, 1, 10)");
            Sql(sql: "insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) values (3, 90, 3, 15)");
            Sql(
                sql:
                "insert into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) values (4, 300, 12, 20)");
        }

        public override void Down()
        {
        }
    }
}