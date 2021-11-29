using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Institucion",
                table: "OfertaServicios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoServicio",
                table: "OfertaServicios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Institucion",
                table: "OfertaServicios");

            migrationBuilder.DropColumn(
                name: "TipoServicio",
                table: "OfertaServicios");
        }
    }
}
