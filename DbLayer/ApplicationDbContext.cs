using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;

namespace DbLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() { }
        // Конструктор с настройками (важно для Dependency Injection)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // DbSet для всех моделей
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Expert> Experts { get; set; }
        public virtual DbSet<ExpertTask> ExpertTasks { get; set; }

        //Настройка моделей(опционально)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка точных типов данных для PostgreSQL
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Report>()
                .Property(r => r.CreationDate)
                .HasColumnType("timestamp with time zone");

            // Другие настройки...
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql()
                    .LogTo(
                        Console.WriteLine,
                        LogLevel.Information
                    );
            }
        }
    }
}
