namespace RelationshipDemo.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyVideoTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
        }
    }
}
