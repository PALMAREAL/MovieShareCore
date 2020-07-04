using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieShareCore.Models;

namespace MovieShareCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }
        
        public DbSet<Genre> Genres { get; set; }
        
        public DbSet<Director> Directors { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
