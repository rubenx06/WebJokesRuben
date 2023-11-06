using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebJokesRuben.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jokes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JokePergunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JokeResposta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jokes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jokes");
        }
    }
}
