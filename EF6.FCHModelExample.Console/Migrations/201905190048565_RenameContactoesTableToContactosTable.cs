namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameContactoesTableToContactosTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contactoes", newName: "Contactos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Contactos", newName: "Contactoes");
        }
    }
}
