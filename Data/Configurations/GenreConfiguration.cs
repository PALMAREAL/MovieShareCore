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
                new Customer { Id = 1, Name = "Action" },
                new Customer { Id = 2, Name = "Adventure" },
                new Customer { Id = 3, Name = "Animation" },
                new Customer { Id = 4, Name = "Biography" },
                new Customer { Id = 5, Name = "Comedy" },
                new Customer { Id = 6, Name = "Crime" },
                new Customer { Id = 7, Name = "Documentary" }, 
                new Customer { Id = 8, Name = "Drama" },
                new Customer { Id = 9, Name = "Fantasy" },
                new Customer { Id = 10, Name = "FilmNoir" },
                new Customer { Id = 11, Name = "History" },
                new Customer { Id = 12, Name = "Horror" },
                new Customer { Id = 13, Name = "Musical" },
                new Customer { Id = 14, Name = "Mistery" },
                new Customer { Id = 15, Name = "Romance" },
                new Customer { Id = 16, Name = "SciFi" },
                new Customer { Id = 17, Name = "Sport" },
                new Customer { Id = 18, Name = "Thriller" },
                new Customer { Id = 19, Name = "War" },
                new Customer { Id = 20, Name = "Western" }
            );
        }
    }
}