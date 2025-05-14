using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CulturaVivaTours.API.Migrations
{
    /// <inheritdoc />
    public partial class updateproveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Proveedores");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Proveedores",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Proveedores",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Proveedores",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
