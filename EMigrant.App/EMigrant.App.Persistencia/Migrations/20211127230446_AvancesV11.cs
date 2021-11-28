using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Necesidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadSalud = table.Column<int>(type: "int", nullable: false),
                    DescripcionEmpleo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadEmpleo = table.Column<int>(type: "int", nullable: false),
                    DescripcionEducacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadEducacion = table.Column<int>(type: "int", nullable: false),
                    DescripcionAyudaLegal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadAyudaLegal = table.Column<int>(type: "int", nullable: false),
                    DescripcionAlojaTemporal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadTemporal = table.Column<int>(type: "int", nullable: false),
                    DescripcionAlojaPermanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadAlojaPermanente = table.Column<int>(type: "int", nullable: false),
                    DescripcionAlimentacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadAlimentacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidad", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Necesidad");
        }
    }
}
