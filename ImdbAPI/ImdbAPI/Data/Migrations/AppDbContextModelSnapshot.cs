﻿// <auto-generated />
using System;
using ImdbAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ImdbAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ImdbAPI.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Antonio",
                            Surname = "Banderas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Leonardo",
                            Surname = "DiCaprio"
                        });
                });

            modelBuilder.Entity("ImdbAPI.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("AverageRating")
                        .HasColumnType("double precision");

                    b.Property<string>("CoverImage")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageRating = 8.4000000000000004,
                            CoverImage = "http://slika.jpeg",
                            Description = "ovo je desc",
                            ReleaseDate = new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film1"
                        },
                        new
                        {
                            Id = 2,
                            AverageRating = 9.0999999999999996,
                            CoverImage = "http://slika.jpeg",
                            Description = "ovo je desc",
                            ReleaseDate = new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film2"
                        });
                });

            modelBuilder.Entity("ImdbAPI.Models.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("Cast");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 2
                        });
                });

            modelBuilder.Entity("ImdbAPI.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("StarRating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            StarRating = 7
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            StarRating = 7
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 1,
                            StarRating = 6
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 2,
                            StarRating = 9
                        });
                });

            modelBuilder.Entity("ImdbAPI.Models.MovieActor", b =>
                {
                    b.HasOne("ImdbAPI.Models.Actor", "Actor")
                        .WithMany("Cast")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImdbAPI.Models.Movie", "Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ImdbAPI.Models.Rating", b =>
                {
                    b.HasOne("ImdbAPI.Models.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ImdbAPI.Models.Actor", b =>
                {
                    b.Navigation("Cast");
                });

            modelBuilder.Entity("ImdbAPI.Models.Movie", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
