using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Prestamos",
                newName: "BookId");

            migrationBuilder.AddColumn<int>(
                name: "PrestamoId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PrestamoId",
                table: "Books",
                column: "PrestamoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Prestamos_PrestamoId",
                table: "Books",
                column: "PrestamoId",
                principalTable: "Prestamos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Prestamos_PrestamoId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PrestamoId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PrestamoId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Prestamos",
                newName: "Name");
        }
    }
}
