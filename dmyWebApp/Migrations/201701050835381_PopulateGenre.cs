using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql(sql: "insert into Genres (Id, Name) values (1, 'Comedy')");
            Sql(sql: "insert into Genres (Id, Name) values (2, 'Action')");
            Sql(sql: "insert into Genres (Id, Name) values (3, 'Fiction')");
            Sql(sql: "insert into Genres (Id, Name) values (4, 'Family')");
            Sql(sql: "insert into Genres (Id, Name) values (5, 'Romance')");
        }

        public override void Down()
        {
        }
    }
}