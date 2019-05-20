namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateManyToManyRelationshipBetweenEmpresasAndEspecialidadesEmpresasTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpresaEspecialidadesEmpresas",
                c => new
                    {
                        Empresa_Id = c.Int(nullable: false),
                        EspecialidadesEmpresa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Empresa_Id, t.EspecialidadesEmpresa_Id })
                .ForeignKey("dbo.Empresas", t => t.Empresa_Id, cascadeDelete: true)
                .ForeignKey("dbo.EspecialidadesEmpresas", t => t.EspecialidadesEmpresa_Id, cascadeDelete: true)
                .Index(t => t.Empresa_Id)
                .Index(t => t.EspecialidadesEmpresa_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpresaEspecialidadesEmpresas", "EspecialidadesEmpresa_Id", "dbo.EspecialidadesEmpresas");
            DropForeignKey("dbo.EmpresaEspecialidadesEmpresas", "Empresa_Id", "dbo.Empresas");
            DropIndex("dbo.EmpresaEspecialidadesEmpresas", new[] { "EspecialidadesEmpresa_Id" });
            DropIndex("dbo.EmpresaEspecialidadesEmpresas", new[] { "Empresa_Id" });
            DropTable("dbo.EmpresaEspecialidadesEmpresas");
        }
    }
}
