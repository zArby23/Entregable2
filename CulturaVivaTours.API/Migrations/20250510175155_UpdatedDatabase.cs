using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulturaVivaTours.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_PuntosInteres_PuntoInteresid",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Turistas_TuristaId",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosInteres_Proveedores_Proveedorid",
                table: "PuntosInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosInteres_Rutas_RutaId",
                table: "PuntosInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_RutasAsignadas_Guias_GuiaId",
                table: "RutasAsignadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RutasAsignadas_Rutas_RutaId",
                table: "RutasAsignadas");

            migrationBuilder.RenameColumn(
                name: "Proveedorid",
                table: "PuntosInteres",
                newName: "ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_PuntosInteres_Proveedorid",
                table: "PuntosInteres",
                newName: "IX_PuntosInteres_ProveedorId");

            migrationBuilder.RenameColumn(
                name: "PuntoInteresid",
                table: "Calificaciones",
                newName: "PuntoInteresId");

            migrationBuilder.RenameIndex(
                name: "IX_Calificaciones_PuntoInteresid",
                table: "Calificaciones",
                newName: "IX_Calificaciones_PuntoInteresId");

            migrationBuilder.AlterColumn<int>(
                name: "RutaId",
                table: "RutasAsignadas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GuiaId",
                table: "RutasAsignadas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RutaId",
                table: "PuntosInteres",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProveedorId",
                table: "PuntosInteres",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TuristaId",
                table: "Calificaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PuntoInteresId",
                table: "Calificaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_PuntosInteres_PuntoInteresId",
                table: "Calificaciones",
                column: "PuntoInteresId",
                principalTable: "PuntosInteres",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Turistas_TuristaId",
                table: "Calificaciones",
                column: "TuristaId",
                principalTable: "Turistas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosInteres_Proveedores_ProveedorId",
                table: "PuntosInteres",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosInteres_Rutas_RutaId",
                table: "PuntosInteres",
                column: "RutaId",
                principalTable: "Rutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RutasAsignadas_Guias_GuiaId",
                table: "RutasAsignadas",
                column: "GuiaId",
                principalTable: "Guias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RutasAsignadas_Rutas_RutaId",
                table: "RutasAsignadas",
                column: "RutaId",
                principalTable: "Rutas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_PuntosInteres_PuntoInteresId",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Turistas_TuristaId",
                table: "Calificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosInteres_Proveedores_ProveedorId",
                table: "PuntosInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_PuntosInteres_Rutas_RutaId",
                table: "PuntosInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_RutasAsignadas_Guias_GuiaId",
                table: "RutasAsignadas");

            migrationBuilder.DropForeignKey(
                name: "FK_RutasAsignadas_Rutas_RutaId",
                table: "RutasAsignadas");

            migrationBuilder.RenameColumn(
                name: "ProveedorId",
                table: "PuntosInteres",
                newName: "Proveedorid");

            migrationBuilder.RenameIndex(
                name: "IX_PuntosInteres_ProveedorId",
                table: "PuntosInteres",
                newName: "IX_PuntosInteres_Proveedorid");

            migrationBuilder.RenameColumn(
                name: "PuntoInteresId",
                table: "Calificaciones",
                newName: "PuntoInteresid");

            migrationBuilder.RenameIndex(
                name: "IX_Calificaciones_PuntoInteresId",
                table: "Calificaciones",
                newName: "IX_Calificaciones_PuntoInteresid");

            migrationBuilder.AlterColumn<int>(
                name: "RutaId",
                table: "RutasAsignadas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GuiaId",
                table: "RutasAsignadas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RutaId",
                table: "PuntosInteres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Proveedorid",
                table: "PuntosInteres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TuristaId",
                table: "Calificaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PuntoInteresid",
                table: "Calificaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_PuntosInteres_PuntoInteresid",
                table: "Calificaciones",
                column: "PuntoInteresid",
                principalTable: "PuntosInteres",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Turistas_TuristaId",
                table: "Calificaciones",
                column: "TuristaId",
                principalTable: "Turistas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosInteres_Proveedores_Proveedorid",
                table: "PuntosInteres",
                column: "Proveedorid",
                principalTable: "Proveedores",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PuntosInteres_Rutas_RutaId",
                table: "PuntosInteres",
                column: "RutaId",
                principalTable: "Rutas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RutasAsignadas_Guias_GuiaId",
                table: "RutasAsignadas",
                column: "GuiaId",
                principalTable: "Guias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RutasAsignadas_Rutas_RutaId",
                table: "RutasAsignadas",
                column: "RutaId",
                principalTable: "Rutas",
                principalColumn: "Id");
        }
    }
}
