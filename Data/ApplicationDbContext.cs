﻿using Microsoft.EntityFrameworkCore;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public
            ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        { 
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="茶飲", DisplayOrder =10 },
                new Category { Id=2, Name="水果茶", DisplayOrder =20 },
                new Category { Id=3, Name="咖啡", DisplayOrder =30 }
                );
        }
    }
}
