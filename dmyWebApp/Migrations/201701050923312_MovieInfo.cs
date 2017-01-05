using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class MovieInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn(table: "dbo.Movies", name: "ReleaseDate", columnAction: c => c.DateTime(nullable: false));
            AddColumn(table: "dbo.Movies", name: "AddedDate", columnAction: c => c.DateTime(nullable: false));
            AddColumn(table: "dbo.Movies", name: "InStock", columnAction: c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn(table: "dbo.Movies", name: "InStock");
            DropColumn(table: "dbo.Movies", name: "AddedDate");
            DropColumn(table: "dbo.Movies", name: "ReleaseDate");
        }
    }
}