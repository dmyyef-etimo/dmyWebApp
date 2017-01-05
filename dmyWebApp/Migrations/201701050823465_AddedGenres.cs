using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class AddedGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    name: "dbo.Genres",
                    columnsAction: c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255)
                    })
                .PrimaryKey(t => t.Id);

            AddColumn(table: "dbo.Movies", name: "Genre_Id", columnAction: c => c.Byte());
            CreateIndex(table: "dbo.Movies", column: "Genre_Id");
            AddForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres",
                principalColumn: "Id");
        }

        public override void Down()
        {
            DropForeignKey(dependentTable: "dbo.Movies", dependentColumn: "Genre_Id", principalTable: "dbo.Genres");
            DropIndex(table: "dbo.Movies", columns: new[] {"Genre_Id"});
            DropColumn(table: "dbo.Movies", name: "Genre_Id");
            DropTable(name: "dbo.Genres");
        }
    }
}