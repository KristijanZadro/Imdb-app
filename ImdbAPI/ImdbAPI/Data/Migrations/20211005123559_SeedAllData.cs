using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImdbAPI.Data.Migrations
{
    public partial class SeedAllData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 3, "Daniel", "Craig" },
                    { 4, "Robert", "Downey Jr" },
                    { 5, "Vin", "Diesel" },
                    { 6, "Morgan", "Freeman" },
                    { 7, "Nikola", "Kojo" },
                    { 8, "Mustafa", "Nadarević" },
                    { 9, "Dejan", "Kotiga" },
                    { 10, "Kevin", "Hart" }
                });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Ironman 1");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GroupType", "Title" },
                values: new object[] { 1, "Ironman 2" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "AverageRating", "CoverImage", "Description", "GroupType", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 16, 8.9000000000000004, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2015, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potjera" },
                    { 24, 10.0, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2008, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lud,zbunjen,normalan" },
                    { 23, 8.0999999999999996, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2014, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kriza" },
                    { 22, 9.9000000000000004, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2013, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naruto" },
                    { 21, 8.6999999999999993, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2017, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaky Blinders" },
                    { 20, 9.6999999999999993, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La Casa de Papel" },
                    { 19, 8.4000000000000004, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lupin" },
                    { 18, 8.5999999999999996, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "How I Met Your Mother" },
                    { 17, 3.5, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2013, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zadruga" },
                    { 15, 8.0, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2008, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Večera za 5" },
                    { 11, 9.9000000000000004, "http://slika.jpeg", "ovo je desc", 1, new DateTime(1989, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swanshank Redemption" },
                    { 13, 9.0999999999999996, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elen" },
                    { 12, 9.5999999999999996, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 10, 9.1999999999999993, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumanji" },
                    { 9, 9.6999999999999993, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2016, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wolf of Wall Street" },
                    { 8, 8.9000000000000004, "http://slika.jpeg", "ovo je desc", 1, new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobit" },
                    { 7, 9.3000000000000007, "http://slika.jpeg", "ovo je desc", 1, new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord of rings" },
                    { 6, 7.5, "http://slika.jpeg", "ovo je desc", 1, new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "James Bond" },
                    { 5, 10.0, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2018, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers" },
                    { 4, 9.5, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2002, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast and furious" },
                    { 3, 8.0999999999999996, "http://slika.jpeg", "ovo je desc", 1, new DateTime(2005, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ironman 3" },
                    { 14, 9.4000000000000004, "http://slika.jpeg", "ovo je desc", 2, new DateTime(2010, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zvezde Granda" }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "ActorId", "MediaId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 7, 11 },
                    { 3, 11 },
                    { 9, 24 },
                    { 1, 12 },
                    { 6, 13 },
                    { 7, 13 },
                    { 3, 14 },
                    { 6, 14 },
                    { 9, 15 },
                    { 2, 15 },
                    { 1, 16 },
                    { 3, 16 },
                    { 5, 17 },
                    { 10, 17 },
                    { 4, 18 },
                    { 8, 18 },
                    { 9, 19 },
                    { 4, 19 },
                    { 1, 20 },
                    { 2, 20 },
                    { 1, 21 },
                    { 7, 21 },
                    { 8, 22 },
                    { 2, 22 },
                    { 5, 23 },
                    { 3, 23 },
                    { 7, 24 },
                    { 5, 10 },
                    { 9, 10 },
                    { 2, 12 },
                    { 9, 6 },
                    { 7, 5 },
                    { 10, 6 },
                    { 5, 4 },
                    { 3, 7 },
                    { 1, 4 },
                    { 7, 7 },
                    { 3, 8 },
                    { 8, 3 },
                    { 8, 5 },
                    { 6, 3 },
                    { 5, 2 },
                    { 1, 9 },
                    { 4, 2 },
                    { 10, 9 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "StarRating" },
                values: new object[,]
                {
                    { 32, 22, 9 },
                    { 5, 3, 2 },
                    { 28, 18, 3 },
                    { 6, 3, 7 },
                    { 30, 20, 9 },
                    { 33, 23, 6 },
                    { 7, 4, 5 },
                    { 29, 19, 5 },
                    { 8, 4, 9 },
                    { 31, 21, 4 },
                    { 17, 9, 6 },
                    { 27, 17, 1 },
                    { 19, 10, 6 },
                    { 20, 10, 9 },
                    { 16, 8, 8 },
                    { 21, 11, 6 },
                    { 15, 8, 4 },
                    { 22, 12, 9 },
                    { 14, 7, 9 },
                    { 9, 5, 1 },
                    { 23, 13, 4 },
                    { 24, 14, 7 },
                    { 12, 6, 9 },
                    { 25, 15, 9 },
                    { 11, 6, 8 },
                    { 26, 16, 8 },
                    { 18, 9, 9 },
                    { 10, 5, 7 },
                    { 13, 7, 2 },
                    { 34, 24, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 21 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 8, 22 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "ActorId", "MediaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Film1");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GroupType", "Title" },
                values: new object[] { 2, "Film2" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MediaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "MediaId",
                value: 1);
        }
    }
}
