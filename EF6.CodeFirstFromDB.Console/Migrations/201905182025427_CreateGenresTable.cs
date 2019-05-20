namespace EF6.CodeFirstFromDB.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGenresTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genres");
        }
    }
}
