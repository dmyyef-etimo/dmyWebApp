using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class MovieInfoRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres");
            DropIndex(table: "dbo.Movies", columns: new[] {"Genre_Id"});
            AlterColumn(table: "dbo.Movies", name: "Name", columnAction: c => c.String(nullable: false, maxLength: 255));
            AlterColumn(table: "dbo.Movies", name: "Genre_Id", columnAction: c => c.Byte(nullable: false));
            CreateIndex(table: "dbo.Movies", column: "Genre_Id");
            AddForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres",
                principalColumn: "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres");
            DropIndex(table: "dbo.Movies", columns: new[] {"Genre_Id"});
            AlterColumn(table: "dbo.Movies", name: "Genre_Id", columnAction: c => c.Byte());
            AlterColumn(table: "dbo.Movies", name: "Name", columnAction: c => c.String());
            CreateIndex(table: "dbo.Movies", column: "Genre_Id");
            AddForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres",
                principalColumn: "Id");
        }
    }
}