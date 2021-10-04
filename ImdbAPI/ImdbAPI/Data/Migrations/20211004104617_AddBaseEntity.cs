using Microsoft.EntityFrameworkCore.Migrations;

namespace ImdbAPI.Data.Migrations
{
    public partial class AddBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Actor_ActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Movie_MovieId",
                table: "MovieActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "MovieActor",
                newName: "Cast");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Actor",
                newName: "Actors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_ActorId",
                table: "Cast",
                newName: "IX_Cast_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cast",
                table: "Cast",
                columns: new[] { "MovieId", "ActorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Actors_ActorId",
                table: "Cast",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Actors_ActorId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cast",
                table: "Cast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "Cast",
                newName: "MovieActor");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "Actor");

            migrationBuilder.RenameIndex(
                name: "IX_Cast_ActorId",
                table: "MovieActor",
                newName: "IX_MovieActor_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor",
                columns: new[] { "MovieId", "ActorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                table: "Actor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Actor_ActorId",
                table: "MovieActor",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Movie_MovieId",
                table: "MovieActor",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
