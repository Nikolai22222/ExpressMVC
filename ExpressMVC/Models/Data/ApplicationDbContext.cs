using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpressMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace ExpressMVC.Data
{

        public class ApplicationDbContext : IdentityDbContext
        {
            public DbSet<CouchType>CouchTypes  { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<CouchType>().ToTable("Couch");
            }
        }
    
}
