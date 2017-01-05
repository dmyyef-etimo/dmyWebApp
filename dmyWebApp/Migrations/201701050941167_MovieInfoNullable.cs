using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class MovieInfoNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn(table: "dbo.Movies", name: "ReleaseDate", columnAction: c => c.DateTime());
            AlterColumn(table: "dbo.Movies", name: "AddedDate", columnAction: c => c.DateTime());
            AlterColumn(table: "dbo.Movies", name: "InStock", columnAction: c => c.Int());
        }

        public override void Down()
        {
            AlterColumn(table: "dbo.Movies", name: "InStock", columnAction: c => c.Int(nullable: false));
            AlterColumn(table: "dbo.Movies", name: "AddedDate", columnAction: c => c.DateTime(nullable: false));
            AlterColumn(table: "dbo.Movies", name: "ReleaseDate", columnAction: c => c.DateTime(nullable: false));
        }
    }
}