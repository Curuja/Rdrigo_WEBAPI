using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Design;
using Domain.Entities;
using Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class databaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
