using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DivTech.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_fornecedores",
                table: "fornecedores");

            migrationBuilder.RenameTable(
                name: "fornecedores",
                newName: "Fornecedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "fornecedores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fornecedores",
                table: "fornecedores",
                column: "Id");
        }
    }
}
