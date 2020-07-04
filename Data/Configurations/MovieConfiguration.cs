using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShareCore.Models;
using System;

namespace MovieShareCore.Data.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.HasData
            (
                new Movie
                { 
                    Title = "City Lights", 
                    Director = "Charles Chaplin", 
                    ReleaseDate = new DateTime(1931, 2, 15),
                    Duration = 81,
                    GenreId = 9,
                    Country = "USA", 
                    Budget = 250000 
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    Director = "Quentin Tarantino",
                    ReleaseDate = new DateTime(1994, 5, 12),
                    Duration = 153,
                    GenreId = 1,
                    Country = "USA",
                    Budget = 8000000
                },
                new Movie
                {
                    Title = "Vertigo",
                    Director = "Alfred Hitchcock",
                    ReleaseDate = new DateTime(1958, 6, 1),
                    Duration = 128,
                    GenreId = 1,
                    Country = "USA",
                    Budget = 2500000
                },
                new Movie
                {
                    Title = "The seven Samurai",
                    Director = "Akira Kurosawa",
                    ReleaseDate = new DateTime(1954, 1, 1),
                    Duration = 207,
                    GenreId = 1,
                    Country = "JAPAN",
                    Budget = 5000000
                },
                new Movie
                {
                    Title = "Roma",
                    Director = "Alfonso Cuarón",
                    ReleaseDate = new DateTime(2018, 1, 1),
                    Duration = 135,
                    GenreId = 1,
                    Country = "USA",
                    Budget = 15000000
                }
            );
        }
    }
}