namespace RelationshipDemo.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyRelationshipBetweenVideosAndTagsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoTags",
                c => new
                    {
                        VideoID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VideoID, t.TagID })
                .ForeignKey("dbo.Videos", t => t.VideoID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.VideoID)
                .Index(t => t.TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.VideoTags", "VideoID", "dbo.Videos");
            DropIndex("dbo.VideoTags", new[] { "TagID" });
            DropIndex("dbo.VideoTags", new[] { "VideoID" });
            DropTable("dbo.VideoTags");
        }
    }
}
