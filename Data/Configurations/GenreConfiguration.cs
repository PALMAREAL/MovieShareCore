using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShareCore.Models;
using System;

namespace MovieShareCore.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres");

            builder.HasData
            (
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Adventure" },
                new Genre { Id = 3, Name = "Animation" },
                new Genre { Id = 4, Name = "Biography" },
                new Genre { Id = 5, Name = "Comedy" },
                new Genre { Id = 6, Name = "Crime" },
                new Genre { Id = 7, Name = "Documentary" }, 
                new Genre { Id = 8, Name = "Drama" },
                new Genre { Id = 9, Name = "Fantasy" },
                new Genre { Id = 10, Name = "FilmNoir" },
                new Genre { Id = 11, Name = "History" },
                new Genre { Id = 12, Name = "Horror" },
                new Genre { Id = 13, Name = "Musical" },
                new Genre { Id = 14, Name = "Mistery" },
                new Genre { Id = 15, Name = "Romance" },
                new Genre { Id = 16, Name = "SciFi" },
                new Genre { Id = 17, Name = "Sport" },
                new Genre { Id = 18, Name = "Thriller" },
                new Genre { Id = 19, Name = "War" },
                new Genre { Id = 20, Name = "Western" }
            );
        }
    }
}