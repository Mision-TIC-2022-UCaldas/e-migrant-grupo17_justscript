using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "migrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacionLaboral = table.Column<int>(type: "int", nullable: false),
                    Saludid = table.Column<int>(type: "int", nullable: true),
                    Alimentacionid = table.Column<int>(type: "int", nullable: true),
                    Empleoid = table.Column<int>(type: "int", nullable: true),
                    AlojoTemporalid = table.Column<int>(type: "int", nullable: true),
                    AlojoPermanenteid = table.Column<int>(type: "int", nullable: true),
                    Educacionid = table.Column<int>(type: "int", nullable: true),
                    AyudaLegalid = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_migrantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_migrantes_Alimentacion_Alimentacionid",
                        column: x => x.Alimentacionid,
                        principalTable: "Alimentacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_AlojoPermanente_AlojoPermanenteid",
                        column: x => x.AlojoPermanenteid,
                        principalTable: "AlojoPermanente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_AlojoTemporal_AlojoTemporalid",
                        column: x => x.AlojoTemporalid,
                        principalTable: "AlojoTemporal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_AyudaLegal_AyudaLegalid",
                        column: x => x.AyudaLegalid,
                        principalTable: "AyudaLegal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_Educacion_Educacionid",
                        column: x => x.Educacionid,
                        principalTable: "Educacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_Empleo_Empleoid",
                        column: x => x.Empleoid,
                        principalTable: "Empleo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_migrantes_Salud_Saludid",
                        column: x => x.Saludid,
                        principalTable: "Salud",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "migrantes");

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
        }
    }
}
