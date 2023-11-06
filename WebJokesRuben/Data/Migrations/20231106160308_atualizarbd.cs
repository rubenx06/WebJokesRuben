using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebJokesRuben.Data.Migrations
{
    /// <inheritdoc />
    public partial class atualizarbd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_jokes",
                table: "jokes");

            migrationBuilder.RenameTable(
                name: "jokes",
                newName: "Jokes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Jokes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Jokes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Jokes");

            migrationBuilder.RenameTable(
                name: "Jokes",
                newName: "jokes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "jokes",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jokes",
                table: "jokes",
                column: "id");
        }
    }
}
