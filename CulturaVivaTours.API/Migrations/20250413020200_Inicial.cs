using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulturaVivaTours.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cedula = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Time = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RestringFood = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Disponibility = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuntosInteres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoActividad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HorarioEstimado = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Proveedorid = table.Column<int>(type: "int", nullable: true),
                    RutaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosInteres", x => x.id);
                    table.ForeignKey(
                        name: "FK_PuntosInteres_Proveedores_Proveedorid",
                        column: x => x.Proveedorid,
                        principalTable: "Proveedores",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PuntosInteres_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RutasAsignadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutaId = table.Column<int>(type: "int", nullable: true),
                    GuiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutasAsignadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RutasAsignadas_Guias_GuiaId",
                        column: x => x.GuiaId,
                        principalTable: "Guias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RutasAsignadas_Rutas_RutaId",
                        column: x => x.RutaId,
                        principalTable: "Rutas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PuntoInteresid = table.Column<int>(type: "int", nullable: true),
                    TuristaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_PuntosInteres_PuntoInteresid",
                        column: x => x.PuntoInteresid,
                        principalTable: "PuntosInteres",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Calificaciones_Turistas_TuristaId",
                        column: x => x.TuristaId,
                        principalTable: "Turistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_PuntoInteresid",
                table: "Calificaciones",
                column: "PuntoInteresid");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_TuristaId",
                table: "Calificaciones",
                column: "TuristaId");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosInteres_Proveedorid",
                table: "PuntosInteres",
                column: "Proveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_PuntosInteres_RutaId",
                table: "PuntosInteres",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_RutasAsignadas_GuiaId",
                table: "RutasAsignadas",
                column: "GuiaId");

            migrationBuilder.CreateIndex(
                name: "IX_RutasAsignadas_RutaId",
                table: "RutasAsignadas",
                column: "RutaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "RutasAsignadas");

            migrationBuilder.DropTable(
                name: "PuntosInteres");

            migrationBuilder.DropTable(
                name: "Turistas");

            migrationBuilder.DropTable(
                name: "Guias");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Rutas");
        }
    }
}
