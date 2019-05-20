namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotNullnameColumnContactosTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contactos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Contactos", "Cargo", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contactos", "Cargo", c => c.String());
            AlterColumn("dbo.Contactos", "Name", c => c.String());
        }
    }
}
