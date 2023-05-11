using Estudo.Domain;
using Estudo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Estudo.Context
{
    public class DataContext:DbContext
    {
        #region Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            //options.UseSqlServer("");
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<Product>();
            

        }
    }
}
