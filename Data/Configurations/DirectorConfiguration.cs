using Microsoft.EntityFrameworkCore;
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
            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.HasData
            (
                new Director
                { 
                    Name = "Steven Spielberg", 
                    Birthdate = new DateTime(1946, 12, 18),
                    Country = "USA", 
                    Knowfor = "Schindler's List"
                },
                new Director
                {
                    Name = "Martin Scorsese",
                    Birthdate = new DateTime(1942, 11, 17),
                    Country = "USA",
                    Knowfor = "Taxi Driver"
                },
                new Director
                {
                    Name = "Alfred Hitchcock",
                    Birthdate = new DateTime(1899, 8, 13),
                    Country = "UK",
                    Knowfor = "Psycho"
                },
                new Director
                {
                    Name = "Haliam Pérez",
                    Birthdate = new DateTime(1982, 2, 16),
                    Country = "CUBA",
                    Knowfor = "Marina"
                },
                new Director
                {
                    Name = "Tomás Gutierres Alea",
                    Birthdate = new DateTime(1928, 12, 11),
                    Country = "Cuba",
                    Knowfor = "Memorias del Subdesarrollo"
                }
            );
        }
    }
}