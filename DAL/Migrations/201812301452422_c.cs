namespace LibraryManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Borrows", "PenaltyId", "dbo.Penalties");
            DropIndex("dbo.Borrows", new[] { "PenaltyId" });
            CreateTable(
                "dbo.BookTranslators",
                c => new
                    {
                        BookId = c.Guid(nullable: false),
                        TranslatorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookId, t.TranslatorId })
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Translators", t => t.TranslatorId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.TranslatorId);
            
            CreateTable(
                "dbo.Translators",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 150),
                        Country = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Theme = c.String(maxLength: 300),
                        FineAmount = c.Decimal(precision: 18, scale: 2),
                        LoanAmount = c.Decimal(precision: 18, scale: 2),
                        AuthorizedNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Borrows", "Penalty", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Members", "NationalCode", c => c.String(nullable: false));
            AddColumn("dbo.Members", "MemberCode", c => c.String(maxLength: 18));
            AddColumn("dbo.Members", "FileId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Books", "Subject", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Borrows", "DeliveryDate", c => c.String(maxLength: 10));
            AlterColumn("dbo.Borrows", "ExpirationDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Members", "RegisteryDate", c => c.String(maxLength: 10));
            CreateIndex("dbo.Users", "FileId");
            AddForeignKey("dbo.Users", "FileId", "dbo.Files", "FileId", cascadeDelete: true);
            DropColumn("dbo.Borrows", "PenaltyId");
            DropColumn("dbo.Borrows", "Dealy");
            DropTable("dbo.Penalties");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        PenaltyId = c.Int(nullable: false, identity: true),
                        From = c.String(nullable: false, maxLength: 5),
                        To = c.String(nullable: false, maxLength: 5),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PenaltyId);
            
            AddColumn("dbo.Borrows", "Dealy", c => c.Int(nullable: false));
            AddColumn("dbo.Borrows", "PenaltyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "FileId", "dbo.Files");
            DropForeignKey("dbo.BookTranslators", "TranslatorId", "dbo.Translators");
            DropForeignKey("dbo.BookTranslators", "BookId", "dbo.Books");
            DropIndex("dbo.Users", new[] { "FileId" });
            DropIndex("dbo.BookTranslators", new[] { "TranslatorId" });
            DropIndex("dbo.BookTranslators", new[] { "BookId" });
            AlterColumn("dbo.Members", "RegisteryDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Borrows", "ExpirationDate", c => c.String(maxLength: 10));
            AlterColumn("dbo.Borrows", "DeliveryDate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Books", "Subject", c => c.String(nullable: false, maxLength: 4000));
            DropColumn("dbo.Members", "FileId");
            DropColumn("dbo.Members", "MemberCode");
            DropColumn("dbo.Members", "NationalCode");
            DropColumn("dbo.Borrows", "Penalty");
            DropTable("dbo.Settings");
            DropTable("dbo.Translators");
            DropTable("dbo.BookTranslators");
            CreateIndex("dbo.Borrows", "PenaltyId");
            AddForeignKey("dbo.Borrows", "PenaltyId", "dbo.Penalties", "PenaltyId", cascadeDelete: true);
        }
    }
}
