namespace LibraryManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_menu_rolemenu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Order = c.Short(nullable: false),
                        ParentId = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Disable = c.Boolean(nullable: false),
                        Url = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.RoleMenus",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        MenuId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.MenuId })
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleMenus", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RoleMenus", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.Menus", "ParentId", "dbo.Menus");
            DropIndex("dbo.RoleMenus", new[] { "MenuId" });
            DropIndex("dbo.RoleMenus", new[] { "RoleId" });
            DropIndex("dbo.Menus", new[] { "ParentId" });
            DropTable("dbo.RoleMenus");
            DropTable("dbo.Menus");
        }
    }
}
