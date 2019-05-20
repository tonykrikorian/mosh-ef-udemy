namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEspecialidadesEmpresasTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EspecialidadesEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EspecialidadesEmpresas");
        }
    }
}
