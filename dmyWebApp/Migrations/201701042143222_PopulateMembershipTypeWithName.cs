using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class PopulateMembershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql(sql: "update MembershipTypes set Name = 'Pay as You Go' where Id = 1");
            Sql(sql: "update MembershipTypes set Name = 'Monthly' where Id = 2");
            Sql(sql: "update MembershipTypes set Name = 'Quarterly' where Id = 3");
            Sql(sql: "update MembershipTypes set Name = 'Yearly' where Id = 4");
        }

        public override void Down()
        {
        }
    }
}