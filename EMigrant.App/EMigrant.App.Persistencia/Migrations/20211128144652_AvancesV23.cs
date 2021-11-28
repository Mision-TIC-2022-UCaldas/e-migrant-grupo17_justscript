using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmigranteId",
                table: "Allegados");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Allegados",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Allegados");

            migrationBuilder.AddColumn<int>(
                name: "EmigranteId",
                table: "Allegados",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
