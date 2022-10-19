using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Prestamos_PrestamoId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PrestamoId",
                table: "Books",
                newName: "PrestamosId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PrestamoId",
                table: "Books",
                newName: "IX_Books_PrestamosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Prestamos_PrestamosId",
                table: "Books",
                column: "PrestamosId",
                principalTable: "Prestamos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Prestamos_PrestamosId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PrestamosId",
                table: "Books",
                newName: "PrestamoId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PrestamosId",
                table: "Books",
                newName: "IX_Books_PrestamoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Prestamos_PrestamoId",
                table: "Books",
                column: "PrestamoId",
                principalTable: "Prestamos",
                principalColumn: "Id");
        }
    }
}
