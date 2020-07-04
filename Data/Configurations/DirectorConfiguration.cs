﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShareCore.Models;
using System;

namespace MovieShareCore.Data.Configurations
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("Directors");

            builder.HasData
            (
                new Director
                { 
                    Id = 2,
                    Name = "Steven Spielberg", 
                    Birthdate = new DateTime(1946, 12, 18),
                    Country = "USA", 
                    Knowfor = "Schindler's List"
                },
                new Director
                {
                    Id = 3,
                    Name = "Martin Scorsese",
                    Birthdate = new DateTime(1942, 11, 17),
                    Country = "USA",
                    Knowfor = "Taxi Driver"
                },
                new Director
                {
                    Id = 4,
                    Name = "Alfred Hitchcock",
                    Birthdate = new DateTime(1899, 8, 13),
                    Country = "UK",
                    Knowfor = "Psycho"
                },
                new Director
                {
                    Id = 6,
                    Name = "Haliam Pérez",
                    Birthdate = new DateTime(1982, 2, 16),
                    Country = "CUBA",
                    Knowfor = "Marina"
                },
                new Director
                {
                    Id = 10,
                    Name = "Tomás Gutierres Alea",
                    Birthdate = new DateTime(1928, 12, 11),
                    Country = "Cuba",
                    Knowfor = "Memorias del Subdesarrollo"
                }
            );
        }
    }
}