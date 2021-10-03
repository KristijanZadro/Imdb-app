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
                   ReleaseDate = new DateTime(2011, 6, 10)
               },
               new Movie
               {
                   Id = 2,
                   Title = "Film2",
                   CoverImage = "http://slika.jpeg",
                   Description = "ovo je desc",
                   ReleaseDate = new DateTime(2000, 3, 15)
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
        }
    }
}
