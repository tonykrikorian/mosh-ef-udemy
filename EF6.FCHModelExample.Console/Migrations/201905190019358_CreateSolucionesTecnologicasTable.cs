namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSolucionesTecnologicasTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SolucionTecnologicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SolucionTecnologicas");
        }
    }
}
