namespace LibraryManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13970826 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        BorrowId = c.Guid(nullable: false),
                        MemberId = c.Guid(nullable: false),
                        BookId = c.Guid(nullable: false),
                        BorrowDate = c.String(nullable: false, maxLength: 10),
                        DeliveryDate = c.String(nullable: false, maxLength: 10),
                        ExtendedDate = c.String(maxLength: 10),
                        ExpirationDate = c.String(maxLength: 10),
                        PenaltyId = c.Int(nullable: false),
                        Dealy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BorrowId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Penalties", t => t.PenaltyId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.BookId)
                .Index(t => t.PenaltyId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 150),
                        BirthDate = c.String(nullable: false, maxLength: 10),
                        IsActive = c.Boolean(nullable: false),
                        RegisteryDate = c.String(nullable: false, maxLength: 10),
                        Tel = c.String(nullable: false, maxLength: 11),
                        Address = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.MemberId);
            
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
            
            AddColumn("dbo.Books", "writer", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrows", "PenaltyId", "dbo.Penalties");
            DropForeignKey("dbo.Borrows", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Borrows", "BookId", "dbo.Books");
            DropIndex("dbo.Borrows", new[] { "PenaltyId" });
            DropIndex("dbo.Borrows", new[] { "BookId" });
            DropIndex("dbo.Borrows", new[] { "MemberId" });
            DropColumn("dbo.Books", "writer");
            DropTable("dbo.Penalties");
            DropTable("dbo.Members");
            DropTable("dbo.Borrows");
        }
    }
}
