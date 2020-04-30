using MBSTU.OnlineShopping.Information.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.ContextModule
{
    public class InformationContext : DbContext, IInformationContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public InformationContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseProduct> PurchaseProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PurchaseProduct>(stdReg =>
            {
                stdReg.HasKey(ur => new { ur.ProductId, ur.CustomerId });

                stdReg.HasOne(sc => sc.Product)
                    .WithMany(s => s.PurchaseProducts)
                    .HasForeignKey(sc => sc.ProductId)
                    .IsRequired();

                stdReg.HasOne(sc => sc.Customer)
                    .WithMany(c => c.PurchaseProducts)
                    .HasForeignKey(sc => sc.CustomerId)
                    .IsRequired();
            });

            base.OnModelCreating(builder);
        }
    }
}
