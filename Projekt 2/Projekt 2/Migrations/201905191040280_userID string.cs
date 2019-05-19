namespace Projekt_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userIDstring : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "User_Id" });
            DropColumn("dbo.Movies", "UserId");
            RenameColumn(table: "dbo.Movies", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Movies", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Movies", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "UserId" });
            AlterColumn("dbo.Movies", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Movies", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "User_Id");
        }
    }
}
