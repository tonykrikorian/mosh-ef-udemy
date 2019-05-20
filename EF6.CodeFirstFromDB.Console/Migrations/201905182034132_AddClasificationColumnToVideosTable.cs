namespace EF6.CodeFirstFromDB.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClasificationColumnToVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
