using ImdbAPI.Models;
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
            builder.Entity<Movie>().HasData(
               new Movie
               {
                   Id = 1,
                   Title = "Film1",
                   CoverImage = "http://slika.jpeg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2011, 6, 10),
                   AverageRating = 8.4
               },
               new Movie
               {
                   Id = 2,
                   Title = "Film2",
                   CoverImage = "http://slika.jpeg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2000, 3, 15),
                   AverageRating = 9.1
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
               }
            );

            builder.Entity<MovieActor>()
            .HasKey(ma => new { ma.MovieId, ma.ActorId });

            builder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.Cast)
                .HasForeignKey(ma => ma.ActorId);

            builder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.Cast)
                .HasForeignKey(ma => ma.MovieId);

            builder.Entity<MovieActor>().HasData(
                new MovieActor { MovieId = 1, ActorId = 1 },
                new MovieActor { MovieId = 1, ActorId = 2 },
                new MovieActor { MovieId = 2, ActorId = 1 },
                new MovieActor { MovieId = 2, ActorId = 2 }
            );

            builder.Entity<Rating>().HasData(
               new Rating
               {
                   Id = 1,
                   StarRating = 7,
                   MovieId = 1
               },
               new Rating
               {
                   Id = 2,
                   StarRating = 7,
                   MovieId = 2
               },
               new Rating
               {
                   Id = 3,
                   StarRating = 6,
                   MovieId = 1
               },
               new Rating
               {
                   Id = 4,
                   StarRating = 9,
                   MovieId = 2
               }
            );
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> Cast { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
