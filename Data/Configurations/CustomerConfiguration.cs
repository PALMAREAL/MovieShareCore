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
            builder.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            builder.HasData
            (
                new Customer 
                { 
                    Name = "Malanga Yuca Frita", 
                    Birthdate = DateTime.Now, 
                    Mail = "mail1@sample.com", 
                    Country = "Cuba", 
                    Admin = true 
                },
                new Customer
                {
                    Name = "Julio Pérez",
                    Birthdate = DateTime.Now,
                    Mail = "mail2@sample.com",
                    Country = "Cuba",
                    Admin = true
                },
                new Customer
                {
                    Name = "Haliam Pérez",
                    Birthdate = DateTime.Now,
                    Mail = "mail3@sample.com",
                    Country = "Cuba",
                    Admin = true
                }
            );
        }
    }
}