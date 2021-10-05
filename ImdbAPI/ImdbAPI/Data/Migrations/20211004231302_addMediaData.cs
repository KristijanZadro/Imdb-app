using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ImdbAPI.Data.Migrations
{
    public partial class addMediaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Ratings",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                newName: "IX_Ratings_MediaId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Cast",
                newName: "MediaId");

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    CoverImage = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AverageRating = table.Column<double>(type: "double precision", nullable: false),
                    GroupType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "AverageRating", "CoverImage", "Description", "GroupType", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 8.4000000000000004, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film1" },
                    { 2, 9.0999999999999996, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Medias_MediaId",
                table: "Cast",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Medias_MediaId",
                table: "Ratings",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Medias_MediaId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Medias_MediaId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Ratings",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                newName: "IX_Ratings_MovieId");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Cast",
                newName: "MovieId");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AverageRating = table.Column<double>(type: "double precision", nullable: false),
                    CoverImage = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AverageRating", "CoverImage", "Description", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 8.4000000000000004, "http://slika.jpeg", "ovo je desc", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film1" },
                    { 2, 9.0999999999999996, "http://slika.jpeg", "ovo je desc", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
