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

            builder.HasData
            (
                new Movie
                {
                    Id = 5,
                    Title = "City Lights", 
                    DirectorId = 2, 
                    ReleaseDate = new DateTime(1931, 2, 15),
                    Duration = 81,
                    GenreId = 9,
                    CountryId = 15, 
                    Budget = 250000 
                },
                new Movie
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    DirectorId = 2,
                    ReleaseDate = new DateTime(1994, 5, 12),
                    Duration = 153,
                    GenreId = 1,
                    CountryId = 14,
                    Budget = 8000000
                },
                new Movie
                {
                    Id = 8,
                    Title = "Vertigo",
                    DirectorId = 2,
                    ReleaseDate = new DateTime(1958, 6, 1),
                    Duration = 128,
                    GenreId = 1,
                    CountryId = 13,
                    Budget = 2500000
                },
                new Movie
                {
                    Id = 10,
                    Title = "The seven Samurai",
                    DirectorId = 2,
                    ReleaseDate = new DateTime(1954, 1, 1),
                    Duration = 207,
                    GenreId = 1,
                    CountryId = 12,
                    Budget = 5000000
                },
                new Movie
                {
                    Id = 11,
                    Title = "Roma",
                    DirectorId = 2,
                    ReleaseDate = new DateTime(2018, 1, 1),
                    Duration = 135,
                    GenreId = 1,
                    CountryId = 11,
                    Budget = 15000000
                }
            );
        }
    }
}