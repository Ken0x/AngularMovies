using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesAPI.Migrations
{
    public partial class UpdateBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTheatersMovies_MovieTheaters_MovieTheaterId",
                table: "MovieTheatersMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieTheatersMovies",
                table: "MovieTheatersMovies");

            migrationBuilder.DropIndex(
                name: "IX_MovieTheatersMovies_MovieTheaterId",
                table: "MovieTheatersMovies");

            migrationBuilder.DropColumn(
                name: "MovieTheatersId",
                table: "MovieTheatersMovies");

            migrationBuilder.AlterColumn<int>(
                name: "MovieTheaterId",
                table: "MovieTheatersMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieTheatersMovies",
                table: "MovieTheatersMovies",
                columns: new[] { "MovieTheaterId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTheatersMovies_MovieTheaters_MovieTheaterId",
                table: "MovieTheatersMovies",
                column: "MovieTheaterId",
                principalTable: "MovieTheaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTheatersMovies_MovieTheaters_MovieTheaterId",
                table: "MovieTheatersMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieTheatersMovies",
                table: "MovieTheatersMovies");

            migrationBuilder.AlterColumn<int>(
                name: "MovieTheaterId",
                table: "MovieTheatersMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MovieTheatersId",
                table: "MovieTheatersMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieTheatersMovies",
                table: "MovieTheatersMovies",
                columns: new[] { "MovieTheatersId", "MovieId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheatersMovies_MovieTheaterId",
                table: "MovieTheatersMovies",
                column: "MovieTheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTheatersMovies_MovieTheaters_MovieTheaterId",
                table: "MovieTheatersMovies",
                column: "MovieTheaterId",
                principalTable: "MovieTheaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
