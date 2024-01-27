using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperDemoData
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProductComplex> ProductsComplex { get; set; } = default!;
        public DbSet<ProductOwned> ProductSOwned { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=AutoMapperDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductComplex>(x => 
                x.ComplexProperty(y => y.Dimension, y => { y.IsRequired();}));

            modelBuilder.Entity<ProductOwned>(x => x.OwnsOne(y => y.Dimension));

            base.OnModelCreating(modelBuilder);
        }
    }
}
