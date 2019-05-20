namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSolucionesTecnologicasTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SolucionTecnologicas", newName: "SolucionesTecnologicas");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SolucionesTecnologicas", newName: "SolucionTecnologicas");
        }
    }
}
