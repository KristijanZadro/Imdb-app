using Microsoft.EntityFrameworkCore.Migrations;

namespace ImdbAPI.Data.Migrations
{
    public partial class addCoverImageUpdateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "movie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "CoverImage",
                value: "movie.jpeg");
        }
    }
}
