namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOneToManyRelationshipBetweenEmpresasAndSolucionesTecnologicasTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolucionTecnologicas", "Empresa_Id", c => c.Int());
            CreateIndex("dbo.SolucionTecnologicas", "Empresa_Id");
            AddForeignKey("dbo.SolucionTecnologicas", "Empresa_Id", "dbo.Empresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SolucionTecnologicas", "Empresa_Id", "dbo.Empresas");
            DropIndex("dbo.SolucionTecnologicas", new[] { "Empresa_Id" });
            DropColumn("dbo.SolucionTecnologicas", "Empresa_Id");
        }
    }
}
