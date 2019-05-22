namespace EF6.CodeFirstFromDB.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetColumnNameNotNullVideosTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "Id", "dbo.Videos");
            DropIndex("dbo.Genres", new[] { "Id" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AddPrimaryKey("dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Genres", "Id");
            AddForeignKey("dbo.Genres", "Id", "dbo.Videos", "Id");
        }
    }
}
