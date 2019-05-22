namespace RelationshipDemo.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyNameColumnInGenreTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
