using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnterpriseProject.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_teste",
                table: "teste");

            migrationBuilder.RenameTable(
                name: "teste",
                newName: "employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employee",
                table: "employee",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employee",
                table: "employee");

            migrationBuilder.RenameTable(
                name: "employee",
                newName: "teste");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teste",
                table: "teste",
                column: "id");
        }
    }
}
