﻿using Microsoft.EntityFrameworkCore;

namespace ProductDataApi.Data
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base (options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           new ProductInitializer(modelBuilder).Seed();
        }
    }
}
