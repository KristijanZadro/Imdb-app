using ImdbAPI.Models;
using ImdbAPI.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Media>().HasData(
               new Media
               {
                   Id = 1,
                   Title = "Ironman 1",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2011, 6, 10),
                   AverageRating = 8.4,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 2,
                   Title = "Ironman 2",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2000, 3, 15),
                   AverageRating = 9.1,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 3,
                   Title = "Ironman 3",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2005, 3, 15),
                   AverageRating = 8.1,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 4,
                   Title = "Fast and furious",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2002, 3, 15),
                   AverageRating = 9.5,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 5,
                   Title = "Avengers",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2018, 3, 15),
                   AverageRating = 10,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 6,
                   Title = "James Bond",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(1990, 3, 15),
                   AverageRating = 7.5,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 7,
                   Title = "Lord of rings",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(1995, 3, 15),
                   AverageRating = 9.3,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 8,
                   Title = "Hobit",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(1998, 3, 15),
                   AverageRating = 8.9,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 9,
                   Title = "Wolf of Wall Street",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2016, 3, 15),
                   AverageRating = 9.7,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 10,
                   Title = "Jumanji",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2020, 3, 15),
                   AverageRating = 9.2,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 11,
                   Title = "Swanshank Redemption",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(1989, 3, 15),
                   AverageRating = 9.9,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 12,
                   Title = "The Godfather",
                   CoverImage = "movie.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2000, 3, 15),
                   AverageRating = 9.6,
                   GroupType = GroupType.Movie
               },
               new Media
               {
                   Id = 13,
                   Title = "Elen",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2000, 3, 15),
                   AverageRating = 9.1,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 14,
                   Title = "Zvezde Granda",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2010, 3, 15),
                   AverageRating = 9.4,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 15,
                   Title = "Večera za 5",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2008, 3, 15),
                   AverageRating = 8,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 16,
                   Title = "Potjera",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2015, 3, 15),
                   AverageRating = 8.9,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 17,
                   Title = "Zadruga",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2013, 3, 15),
                   AverageRating = 3.5,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 18,
                   Title = "How I Met Your Mother",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2005, 3, 15),
                   AverageRating = 8.6,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 19,
                   Title = "Lupin",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2019, 3, 15),
                   AverageRating = 8.4,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 20,
                   Title = "La Casa de Papel",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2020, 3, 15),
                   AverageRating = 9.7,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 21,
                   Title = "Peaky Blinders",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2017, 3, 15),
                   AverageRating = 8.7,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 22,
                   Title = "Naruto",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2013, 3, 15),
                   AverageRating = 9.9,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 23,
                   Title = "Kriza",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2014, 3, 15),
                   AverageRating = 8.1,
                   GroupType = GroupType.TvShow
               },
               new Media
               {
                   Id = 24,
                   Title = "Lud,zbunjen,normalan",
                   CoverImage = "show.jpg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2008, 3, 15),
                   AverageRating = 10,
                   GroupType = GroupType.TvShow
               }
            );

            builder.Entity<Actor>().HasData(
               new Actor
               {
                   Id = 1,
                   Name = "Antonio",
                   Surname = "Banderas"
               },
               new Actor
               {
                   Id = 2,
                   Name = "Leonardo",
                   Surname = "DiCaprio"
               },
               new Actor
               {
                   Id = 3,
                   Name = "Daniel",
                   Surname = "Craig"
               },
               new Actor
               {
                   Id = 4,
                   Name = "Robert",
                   Surname = "Downey Jr"
               },
               new Actor
               {
                   Id = 5,
                   Name = "Vin",
                   Surname = "Diesel"
               },
               new Actor
               {
                   Id = 6,
                   Name = "Morgan",
                   Surname = "Freeman"
               },
               new Actor
               {
                   Id = 7,
                   Name = "Nikola",
                   Surname = "Kojo"
               },
               new Actor
               {
                   Id = 8,
                   Name = "Mustafa",
                   Surname = "Nadarević"
               },
               new Actor
               {
                   Id = 9,
                   Name = "Dejan",
                   Surname = "Kotiga"
               },
               new Actor
               {
                   Id = 10,
                   Name = "Kevin",
                   Surname = "Hart"
               }
            );

            builder.Entity<MediaActor>()
            .HasKey(ma => new { ma.MediaId, ma.ActorId });

            builder.Entity<MediaActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.Cast)
                .HasForeignKey(ma => ma.ActorId);

            builder.Entity<MediaActor>()
                .HasOne(ma => ma.Media)
                .WithMany(m => m.Cast)
                .HasForeignKey(ma => ma.MediaId);

            builder.Entity<MediaActor>().HasData(
                new MediaActor { MediaId = 1, ActorId = 4 },
                new MediaActor { MediaId = 1, ActorId = 2 },
                new MediaActor { MediaId = 2, ActorId = 4 },
                new MediaActor { MediaId = 2, ActorId = 5 },
                new MediaActor { MediaId = 3, ActorId = 6 },
                new MediaActor { MediaId = 3, ActorId = 8 },
                new MediaActor { MediaId = 4, ActorId = 1 },
                new MediaActor { MediaId = 4, ActorId = 5 },
                new MediaActor { MediaId = 5, ActorId = 7 },
                new MediaActor { MediaId = 5, ActorId = 8 },
                new MediaActor { MediaId = 6, ActorId = 9 },
                new MediaActor { MediaId = 6, ActorId = 10 },
                new MediaActor { MediaId = 7, ActorId = 3 },
                new MediaActor { MediaId = 7, ActorId = 7 },
                new MediaActor { MediaId = 8, ActorId = 3 },
                new MediaActor { MediaId = 8, ActorId = 4 },
                new MediaActor { MediaId = 9, ActorId = 1 },
                new MediaActor { MediaId = 9, ActorId = 10 },
                new MediaActor { MediaId = 10, ActorId = 9 },
                new MediaActor { MediaId = 10, ActorId = 5 },
                new MediaActor { MediaId = 11, ActorId = 7 },
                new MediaActor { MediaId = 11, ActorId = 3 },
                new MediaActor { MediaId = 12, ActorId = 2 },
                new MediaActor { MediaId = 12, ActorId = 1 },
                new MediaActor { MediaId = 13, ActorId = 6 },
                new MediaActor { MediaId = 13, ActorId = 7 },
                new MediaActor { MediaId = 14, ActorId = 3 },
                new MediaActor { MediaId = 14, ActorId = 6 },
                new MediaActor { MediaId = 15, ActorId = 9 },
                new MediaActor { MediaId = 15, ActorId = 2 },
                new MediaActor { MediaId = 16, ActorId = 1 },
                new MediaActor { MediaId = 16, ActorId = 3 },
                new MediaActor { MediaId = 17, ActorId = 5 },
                new MediaActor { MediaId = 17, ActorId = 10 },
                new MediaActor { MediaId = 18, ActorId = 4 },
                new MediaActor { MediaId = 18, ActorId = 8 },
                new MediaActor { MediaId = 19, ActorId = 9 },
                new MediaActor { MediaId = 19, ActorId = 4 },
                new MediaActor { MediaId = 20, ActorId = 1 },
                new MediaActor { MediaId = 20, ActorId = 2 },
                new MediaActor { MediaId = 21, ActorId = 1 },
                new MediaActor { MediaId = 21, ActorId = 7 },
                new MediaActor { MediaId = 22, ActorId = 8 },
                new MediaActor { MediaId = 22, ActorId = 2 },
                new MediaActor { MediaId = 23, ActorId = 5 },
                new MediaActor { MediaId = 23, ActorId = 3 },
                new MediaActor { MediaId = 24, ActorId = 7 },
                new MediaActor { MediaId = 24, ActorId = 9 }
            );

            builder.Entity<Rating>().HasData(
               new Rating
               {
                   Id = 1,
                   StarRating = 7,
                   MediaId = 1
               },
               new Rating
               {
                   Id = 2,
                   StarRating = 7,
                   MediaId = 1
               },
               new Rating
               {
                   Id = 3,
                   StarRating = 6,
                   MediaId = 2
               },
               new Rating
               {
                   Id = 4,
                   StarRating = 9,
                   MediaId = 2
               },
               new Rating
               {
                   Id = 5,
                   StarRating = 2,
                   MediaId = 3
               },
               new Rating
               {
                   Id = 6,
                   StarRating = 7,
                   MediaId = 3
               },
               new Rating
               {
                   Id = 7,
                   StarRating = 5,
                   MediaId = 4
               },
               new Rating
               {
                   Id = 8,
                   StarRating = 9,
                   MediaId = 4
               },
               new Rating
               {
                   Id = 9,
                   StarRating = 1,
                   MediaId = 5
               },
               new Rating
               {
                   Id = 10,
                   StarRating = 7,
                   MediaId = 5
               },
               new Rating
               {
                   Id = 11,
                   StarRating = 8,
                   MediaId = 6
               },
               new Rating
               {
                   Id = 12,
                   StarRating = 9,
                   MediaId = 6
               },
               new Rating
               {
                   Id = 13,
                   StarRating = 2,
                   MediaId = 7
               },
               new Rating
               {
                   Id = 14,
                   StarRating = 9,
                   MediaId = 7
               },
               new Rating
               {
                   Id = 15,
                   StarRating = 4,
                   MediaId = 8
               },
               new Rating
               {
                   Id = 16,
                   StarRating = 8,
                   MediaId = 8
               },
               new Rating
               {
                   Id = 17,
                   StarRating = 6,
                   MediaId = 9
               },
               new Rating
               {
                   Id = 18,
                   StarRating = 9,
                   MediaId = 9
               },
               new Rating
               {
                   Id = 19,
                   StarRating = 6,
                   MediaId = 10
               },
               new Rating
               {
                   Id = 20,
                   StarRating = 9,
                   MediaId = 10
               },
               new Rating
               {
                   Id = 21,
                   StarRating = 6,
                   MediaId = 11
               },
               new Rating
               {
                   Id = 22,
                   StarRating = 9,
                   MediaId = 12
               },
               new Rating
               {
                   Id = 23,
                   StarRating = 4,
                   MediaId = 13
               },
               new Rating
               {
                   Id = 24,
                   StarRating = 7,
                   MediaId = 14
               },
               new Rating
               {
                   Id = 25,
                   StarRating = 9,
                   MediaId = 15
               },
               new Rating
               {
                   Id = 26,
                   StarRating = 8,
                   MediaId = 16
               },
               new Rating
               {
                   Id = 27,
                   StarRating = 1,
                   MediaId = 17
               },
               new Rating
               {
                   Id = 28,
                   StarRating = 3,
                   MediaId = 18
               },
               new Rating
               {
                   Id = 29,
                   StarRating = 5,
                   MediaId = 19
               },
               new Rating
               {
                   Id = 30,
                   StarRating = 9,
                   MediaId = 20
               },
               new Rating
               {
                   Id = 31,
                   StarRating = 4,
                   MediaId = 21
               },
               new Rating
               {
                   Id = 32,
                   StarRating = 9,
                   MediaId = 22
               },
               new Rating
               {
                   Id = 33,
                   StarRating = 6,
                   MediaId = 23
               },
               new Rating
               {
                   Id = 34,
                   StarRating = 9,
                   MediaId = 24
               }
            );
        }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MediaActor> Cast { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
