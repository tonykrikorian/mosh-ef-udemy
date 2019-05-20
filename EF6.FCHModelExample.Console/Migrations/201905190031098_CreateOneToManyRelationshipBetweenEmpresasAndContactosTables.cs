namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOneToManyRelationshipBetweenEmpresasAndContactosTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contactoes", "Empresa_Id", c => c.Int());
            CreateIndex("dbo.Contactoes", "Empresa_Id");
            AddForeignKey("dbo.Contactoes", "Empresa_Id", "dbo.Empresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactoes", "Empresa_Id", "dbo.Empresas");
            DropIndex("dbo.Contactoes", new[] { "Empresa_Id" });
            DropColumn("dbo.Contactoes", "Empresa_Id");
        }
    }
}
