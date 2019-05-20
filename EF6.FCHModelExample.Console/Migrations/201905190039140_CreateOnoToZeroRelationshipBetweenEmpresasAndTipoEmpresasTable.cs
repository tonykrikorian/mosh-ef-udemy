namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOnoToZeroRelationshipBetweenEmpresasAndTipoEmpresasTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TipoEmpresas");
            AlterColumn("dbo.TipoEmpresas", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TipoEmpresas", "Id");
            CreateIndex("dbo.TipoEmpresas", "Id");
            AddForeignKey("dbo.TipoEmpresas", "Id", "dbo.Empresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoEmpresas", "Id", "dbo.Empresas");
            DropIndex("dbo.TipoEmpresas", new[] { "Id" });
            DropPrimaryKey("dbo.TipoEmpresas");
            AlterColumn("dbo.TipoEmpresas", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TipoEmpresas", "Id");
        }
    }
}
