using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulturaVivaTours.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPuntosInteres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "PuntosInteres",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PuntosInteres",
                newName: "id");
        }
    }
}
