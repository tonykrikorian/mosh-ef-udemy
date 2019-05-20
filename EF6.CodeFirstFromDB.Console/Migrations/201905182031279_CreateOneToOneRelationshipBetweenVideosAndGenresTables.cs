namespace EF6.CodeFirstFromDB.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOneToOneRelationshipBetweenVideosAndGenresTables : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "Id");
            CreateIndex("dbo.Genres", "Id");
            AddForeignKey("dbo.Genres", "Id", "dbo.Videos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genres", "Id", "dbo.Videos");
            DropIndex("dbo.Genres", new[] { "Id" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "Id");
        }
    }
}
