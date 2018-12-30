namespace LibraryManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Username");
        }
    }
}
