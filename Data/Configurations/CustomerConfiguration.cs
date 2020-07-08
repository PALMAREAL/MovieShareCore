using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShareCore.Models;
using System;

namespace MovieShareCore.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasData
            (
                new Customer 
                { 
                    Id = 2,
                    Name = "Malanga Yuca Frita", 
                    Birthdate = DateTime.Now, 
                    Mail = "mail1@sample.com", 
                    CountryId = 53, 
                    Admin = true 
                },
                new Customer
                {
                    Id = 6,
                    Name = "Julio Pérez",
                    Birthdate = DateTime.Now,
                    Mail = "mail2@sample.com",
                    CountryId = 55,
                    Admin = true
                },
                new Customer
                {
                    Id = 7,
                    Name = "Haliam Pérez",
                    Birthdate = DateTime.Now,
                    Mail = "mail3@sample.com",
                    CountryId = 5,
                    Admin = true
                }
            );
        }
    }
}