namespace LibraryManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 10),
                        Subject = c.String(nullable: false, maxLength: 4000),
                        CategoryId = c.Guid(nullable: false),
                        FileId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Files", t => t.FileId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.FileId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Guid(nullable: false),
                        Context = c.Binary(),
                        ContextType = c.String(nullable: false, maxLength: 10),
                        Title = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.FileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "FileId", "dbo.Files");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "FileId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropTable("dbo.Files");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
        }
    }
}
