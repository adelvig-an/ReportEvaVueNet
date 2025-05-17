using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DbLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // Конструктор с настройками (важно для Dependency Injection)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            options.UseNpgsql(connectionString).LogTo(Console.WriteLine, LogLevel.Information);
        }

        // DbSet для всех моделей
        //public virtual DbSet<Report> Reports { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<Address> Address { get; set; }
        //public virtual DbSet<Contact> Contacts { get; set; }
        //public virtual DbSet<Contractor> Contractors { get; set; }
        //public virtual DbSet<Expert> Experts { get; set; }
        //public virtual DbSet<ExpertTask> ExpertTasks { get; set; }

        // Настройка моделей (опционально)
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Пример настройки связи между Report и Classification
        //    modelBuilder.Entity<Report>()
        //        .HasOne(r => r.Classification)
        //        .WithMany()
        //        .HasForeignKey(r => r.ClassificationId);
        //}

        //var reports = await dbContext.Reports.AsNoTracking().ToListAsync();
    }
}
