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

        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<ApplicationsModel> AppllicationsModels { get; set; }
        public DbSet<ClientsModel> Clients { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<ContractsModel> Contracts { get; set; }
        public DbSet<EmployeesModel> Employees { get; set; }
        public DbSet<ValuationObjectModel> ValuationObjects { get; set; }

        //Настройка моделей(опционально)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка точных типов данных для PostgreSQL
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationsModel>()
                .Property(e => e.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (ApplicationStatus)Enum.Parse(typeof(ApplicationStatus), v)
                );
            modelBuilder.Entity<ContactsModel>()
                .Property(e => e.ContactType)
                .HasConversion(
                    v => v.ToString(),
                    v => (ContactRole)Enum.Parse(typeof(ContactRole), v)
                );
            modelBuilder.Entity<ClientsModel>()
                .Property(e => e.ClientType)
                .HasConversion(
                    v => v.ToString(),
                    v => (ClientType)Enum.Parse(typeof(ClientType), v)
                );
            modelBuilder.Entity<EmployeesModel>()
                .Property(e => e.Position)
                .HasConversion(
                    v => v.ToString(),
                    v => (EmployeePosition)Enum.Parse(typeof(EmployeePosition), v)
                );
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
