namespace RelationshipDemo.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOneToManyRelationshipBetweenVideosAndGenresTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreID", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GenreID");
            AddForeignKey("dbo.Videos", "GenreID", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "GenreID", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "GenreID" });
            DropColumn("dbo.Videos", "GenreID");
        }
    }
}
