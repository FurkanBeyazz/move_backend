using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace move_app_backend.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoveID",
                table: "moviesCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoviesCategoriesID",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MoviesMoviesCategories",
                columns: table => new
                {
                    MoviesCategoriesID = table.Column<int>(type: "int", nullable: false),
                    MoviesMoveID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesMoviesCategories", x => new { x.MoviesCategoriesID, x.MoviesMoveID });
                    table.ForeignKey(
                        name: "FK_MoviesMoviesCategories_moviesCategories_MoviesCategoriesID",
                        column: x => x.MoviesCategoriesID,
                        principalTable: "moviesCategories",
                        principalColumn: "MoviesCategoriesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesMoviesCategories_movies_MoviesMoveID",
                        column: x => x.MoviesMoveID,
                        principalTable: "movies",
                        principalColumn: "MoveID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesMoviesCategories_MoviesMoveID",
                table: "MoviesMoviesCategories",
                column: "MoviesMoveID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesMoviesCategories");

            migrationBuilder.DropColumn(
                name: "MoveID",
                table: "moviesCategories");

            migrationBuilder.DropColumn(
                name: "MoviesCategoriesID",
                table: "movies");
        }
    }
}
