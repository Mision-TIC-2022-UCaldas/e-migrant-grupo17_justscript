using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class migracionEmergencias2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrioridadNecesidades",
                table: "Emergencias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrioridadNecesidades",
                table: "Emergencias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
