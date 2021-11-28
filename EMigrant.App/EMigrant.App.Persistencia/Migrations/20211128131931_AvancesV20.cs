using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Necesidad");

            migrationBuilder.CreateTable(
                name: "Allegados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmigranteId = table.Column<int>(type: "int", nullable: false),
                    IdAllegado = table.Column<int>(type: "int", nullable: false),
                    NombreAllegado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificacionAllegado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoAllegado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allegados", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allegados");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Necesidad",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
