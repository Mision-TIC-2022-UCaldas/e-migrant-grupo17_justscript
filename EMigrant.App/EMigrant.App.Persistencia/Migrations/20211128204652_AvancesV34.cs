using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OfertaServicios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FechaInicioServicio",
                table: "OfertaServicios",
                newName: "FechaInicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "OfertaServicios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "OfertaServicios",
                newName: "FechaInicioServicio");
        }
    }
}
