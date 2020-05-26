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
            : base(options)
        {
        }
        public DbSet<MovieShareCore.Models.Customer> Customers { get; set; }
        public DbSet<MovieShareCore.Models.Movie> Movies { get; set; }
        public DbSet<MovieShareCore.Models.Genre> Genres { get; set; }
        public DbSet<MovieShareCore.Models.Director> Directors { get; set; }
    }
}
