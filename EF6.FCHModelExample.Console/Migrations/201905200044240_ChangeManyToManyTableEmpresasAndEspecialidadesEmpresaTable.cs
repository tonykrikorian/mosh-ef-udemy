namespace EF6.FCHModelExample.Console.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeManyToManyTableEmpresasAndEspecialidadesEmpresaTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmpresaEspecialidadesEmpresas", newName: "EmpresasEspecialidades");
            RenameColumn(table: "dbo.EmpresasEspecialidades", name: "Empresa_Id", newName: "EmpresaID");
            RenameColumn(table: "dbo.EmpresasEspecialidades", name: "EspecialidadesEmpresa_Id", newName: "EspecialidadID");
            RenameIndex(table: "dbo.EmpresasEspecialidades", name: "IX_Empresa_Id", newName: "IX_EmpresaID");
            RenameIndex(table: "dbo.EmpresasEspecialidades", name: "IX_EspecialidadesEmpresa_Id", newName: "IX_EspecialidadID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EmpresasEspecialidades", name: "IX_EspecialidadID", newName: "IX_EspecialidadesEmpresa_Id");
            RenameIndex(table: "dbo.EmpresasEspecialidades", name: "IX_EmpresaID", newName: "IX_Empresa_Id");
            RenameColumn(table: "dbo.EmpresasEspecialidades", name: "EspecialidadID", newName: "EspecialidadesEmpresa_Id");
            RenameColumn(table: "dbo.EmpresasEspecialidades", name: "EmpresaID", newName: "Empresa_Id");
            RenameTable(name: "dbo.EmpresasEspecialidades", newName: "EmpresaEspecialidadesEmpresas");
        }
    }
}
