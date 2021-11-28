using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AvancesV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_Alimentacion_Alimentacionid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_AlojoPermanente_AlojoPermanenteid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_AlojoTemporal_AlojoTemporalid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_AyudaLegal_AyudaLegalid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_Educacion_Educacionid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_Empleo_Empleoid",
                table: "migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_migrantes_Salud_Saludid",
                table: "migrantes");

            migrationBuilder.DropTable(
                name: "Alimentacion");

            migrationBuilder.DropTable(
                name: "AlojoPermanente");

            migrationBuilder.DropTable(
                name: "AlojoTemporal");

            migrationBuilder.DropTable(
                name: "AyudaLegal");

            migrationBuilder.DropTable(
                name: "Educacion");

            migrationBuilder.DropTable(
                name: "Empleo");

            migrationBuilder.DropTable(
                name: "Salud");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_Alimentacionid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_AlojoPermanenteid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_AlojoTemporalid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_AyudaLegalid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_Educacionid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_Empleoid",
                table: "migrantes");

            migrationBuilder.DropIndex(
                name: "IX_migrantes_Saludid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "Alimentacionid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "AlojoPermanenteid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "AlojoTemporalid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "AyudaLegalid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "Educacionid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "Empleoid",
                table: "migrantes");

            migrationBuilder.DropColumn(
                name: "Saludid",
                table: "migrantes");

            migrationBuilder.RenameColumn(
                name: "cat",
                table: "migrantes",
                newName: "necesidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "necesidadId",
                table: "migrantes",
                newName: "cat");

            migrationBuilder.AddColumn<int>(
                name: "Alimentacionid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlojoPermanenteid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlojoTemporalid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AyudaLegalid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Educacionid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Empleoid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Saludid",
                table: "migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alimentacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlojoPermanente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlojoPermanente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlojoTemporal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlojoTemporal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AyudaLegal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AyudaLegal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Educacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empleo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Salud",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salud", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_Alimentacionid",
                table: "migrantes",
                column: "Alimentacionid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_AlojoPermanenteid",
                table: "migrantes",
                column: "AlojoPermanenteid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_AlojoTemporalid",
                table: "migrantes",
                column: "AlojoTemporalid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_AyudaLegalid",
                table: "migrantes",
                column: "AyudaLegalid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_Educacionid",
                table: "migrantes",
                column: "Educacionid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_Empleoid",
                table: "migrantes",
                column: "Empleoid");

            migrationBuilder.CreateIndex(
                name: "IX_migrantes_Saludid",
                table: "migrantes",
                column: "Saludid");

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_Alimentacion_Alimentacionid",
                table: "migrantes",
                column: "Alimentacionid",
                principalTable: "Alimentacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_AlojoPermanente_AlojoPermanenteid",
                table: "migrantes",
                column: "AlojoPermanenteid",
                principalTable: "AlojoPermanente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_AlojoTemporal_AlojoTemporalid",
                table: "migrantes",
                column: "AlojoTemporalid",
                principalTable: "AlojoTemporal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_AyudaLegal_AyudaLegalid",
                table: "migrantes",
                column: "AyudaLegalid",
                principalTable: "AyudaLegal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_Educacion_Educacionid",
                table: "migrantes",
                column: "Educacionid",
                principalTable: "Educacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_Empleo_Empleoid",
                table: "migrantes",
                column: "Empleoid",
                principalTable: "Empleo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_migrantes_Salud_Saludid",
                table: "migrantes",
                column: "Saludid",
                principalTable: "Salud",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
