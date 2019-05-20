namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTiposEmpresaTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TipoEmpresas", newName: "TiposEmpresa");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TiposEmpresa", newName: "TipoEmpresas");
        }
    }
}
