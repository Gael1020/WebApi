using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Editorial_editorialId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editorial",
                table: "Editorial");

            migrationBuilder.RenameTable(
                name: "Editorial",
                newName: "Editorials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editorials",
                table: "Editorials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Editorials_editorialId",
                table: "Books",
                column: "editorialId",
                principalTable: "Editorials",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Editorials_editorialId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editorials",
                table: "Editorials");

            migrationBuilder.RenameTable(
                name: "Editorials",
                newName: "Editorial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editorial",
                table: "Editorial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Editorial_editorialId",
                table: "Books",
                column: "editorialId",
                principalTable: "Editorial",
                principalColumn: "Id");
        }
    }
}
