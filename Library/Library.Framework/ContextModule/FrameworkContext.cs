using Library.Framework.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.ContextModule
{
    public class FrameworkContext : DbContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

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
            builder.Entity<StudentRegistration>()
                .HasKey(pc => new { pc.StudentId, pc.BookId });

            builder.Entity<StudentRegistration>()
                .HasOne(pc => pc.Student)
                .WithMany(p => p.StudentRegistrations)
                .HasForeignKey(pc => pc.StudentId);

            builder.Entity<StudentRegistration>()
                .HasOne(pc => pc.Book)
                .WithMany(c => c.StudentRegistrations)
                .HasForeignKey(pc => pc.BookId);
            base.OnModelCreating(builder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentRegistration> Registrations { get; set; }

    }
}
