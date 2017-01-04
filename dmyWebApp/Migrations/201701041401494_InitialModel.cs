using System.Data.Entity.Migrations;

namespace dmyWebApp.Migrations
{
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    name: "dbo.Customers",
                    columnsAction: c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    name: "dbo.Movies",
                    columnsAction: c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    name: "dbo.AspNetRoles",
                    columnsAction: c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256)
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                    name: "dbo.AspNetUserRoles",
                    columnsAction: c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128)
                    })
                .PrimaryKey(t => new {t.UserId, t.RoleId})
                .ForeignKey(principalTable: "dbo.AspNetRoles", dependentKeyExpression: t => t.RoleId,
                    cascadeDelete: true)
                .ForeignKey(principalTable: "dbo.AspNetUsers", dependentKeyExpression: t => t.UserId,
                    cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                    name: "dbo.AspNetUsers",
                    columnsAction: c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256)
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                    name: "dbo.AspNetUserClaims",
                    columnsAction: c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String()
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey(principalTable: "dbo.AspNetUsers", dependentKeyExpression: t => t.UserId,
                    cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                    name: "dbo.AspNetUserLogins",
                    columnsAction: c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128)
                    })
                .PrimaryKey(t => new {t.LoginProvider, t.ProviderKey, t.UserId})
                .ForeignKey(principalTable: "dbo.AspNetUsers", dependentKeyExpression: t => t.UserId,
                    cascadeDelete: true)
                .Index(t => t.UserId);
        }

        public override void Down()
        {
            DropForeignKey(dependentTable: "dbo.AspNetUserRoles", dependentColumn: "UserId",
                principalTable: "dbo.AspNetUsers");
            DropForeignKey(dependentTable: "dbo.AspNetUserLogins", dependentColumn: "UserId",
                principalTable: "dbo.AspNetUsers");
            DropForeignKey(dependentTable: "dbo.AspNetUserClaims", dependentColumn: "UserId",
                principalTable: "dbo.AspNetUsers");
            DropForeignKey(dependentTable: "dbo.AspNetUserRoles", dependentColumn: "RoleId",
                principalTable: "dbo.AspNetRoles");
            DropIndex(table: "dbo.AspNetUserLogins", columns: new[] {"UserId"});
            DropIndex(table: "dbo.AspNetUserClaims", columns: new[] {"UserId"});
            DropIndex(table: "dbo.AspNetUsers", name: "UserNameIndex");
            DropIndex(table: "dbo.AspNetUserRoles", columns: new[] {"RoleId"});
            DropIndex(table: "dbo.AspNetUserRoles", columns: new[] {"UserId"});
            DropIndex(table: "dbo.AspNetRoles", name: "RoleNameIndex");
            DropTable(name: "dbo.AspNetUserLogins");
            DropTable(name: "dbo.AspNetUserClaims");
            DropTable(name: "dbo.AspNetUsers");
            DropTable(name: "dbo.AspNetUserRoles");
            DropTable(name: "dbo.AspNetRoles");
            DropTable(name: "dbo.Movies");
            DropTable(name: "dbo.Customers");
        }
    }
}