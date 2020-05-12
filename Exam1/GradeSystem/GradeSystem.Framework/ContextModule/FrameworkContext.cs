using GradeSystem.Framework.Entity;
using Microsoft.EntityFrameworkCore;

namespace GradeSystem.Framework.ContextModule
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

            builder.Entity<Grade>()
                .HasOne(pc => pc.Student)
                .WithMany(p => p.Grades)
                .HasForeignKey(pc => pc.StudentId);

            builder.Entity<Grade>()
                .HasOne(pc => pc.Subject)
                .WithMany(c => c.Grades)
                .HasForeignKey(pc => pc.SubjectId);
            base.OnModelCreating(builder);
        }

       
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
