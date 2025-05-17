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
        public DbSet<ContractModel> Contracts { get; set; }
        public DbSet<ReportModel> Reports { get; set; }
        public DbSet<ContactModel> Contacts { get; set; }
        public DbSet<ManagementModel> Management { get; set; }
        public DbSet<CounterpartyModel> Counterparty { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<ExpertModel> Experts { get; set; }
        public DbSet<ExpertOrganizationModel> ExpertOrganizations { get; set; }
        public DbSet<ExpertQualificationModel> ExpertQualifications { get; set; }
        public DbSet<InsurancePolicyModel> InsurancePolicies { get; set; }
        public DbSet<SROrganizationModel> SROrganizations { get; set; }

        //Настройка моделей(опционально)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка точных типов данных для PostgreSQL
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ContractModel>()
                .Property(e => e.ContractType)
                .HasConversion(v => v.ToString(),
                v => (ContractType)Enum.Parse(typeof(ContractType), v));
            modelBuilder.Entity<ContractModel>()
                .Property(e => e.StatusContract)
                .HasConversion(v => v.ToString(),
                v => (StatusType)Enum.Parse(typeof(StatusType), v));
            modelBuilder.Entity<ContractModel>()
                .Property(e => e.PaymentStatusContract)
                .HasConversion(v => v.ToString(),
                v => (PaymentStatusType)Enum.Parse(typeof(PaymentStatusType), v));
            modelBuilder.Entity<ReportModel>()
                .Property(e => e.ReportType)
                .HasConversion(v => v.ToString(),
                v => (ReportType)Enum.Parse(typeof(ReportType), v));
            modelBuilder.Entity<ManagementModel>()
                .Property(e => e.AuthorizationDocuments)
                .HasConversion(v => v.ToString(),
                v => (AuthorizationDocuments)Enum.Parse(typeof(AuthorizationDocuments), v));
            modelBuilder.Entity<CounterpartyModel>()
                .Property(e => e.CounterpartyType)
                .HasConversion(v => v.ToString(),
                v => (CounterpartyType)Enum.Parse(typeof(CounterpartyType), v));
            modelBuilder.Entity<ExpertQualificationModel>()
                .Property(e => e.QualificationType)
                .HasConversion(v => v.ToString(),
                v => (QualificationType)Enum.Parse(typeof(QualificationType), v));
            modelBuilder.Entity<ExpertQualificationModel>()
                .Property(e => e.SpecialityType)
                .HasConversion(v => v.ToString(),
                v => (SpecialityType)Enum.Parse(typeof(SpecialityType), v));
            modelBuilder.Entity<SROrganizationModel>()
                .Property(e => e.SROrganizationType)
                .HasConversion(v => v.ToString(),
                v => (SROrganizationType)Enum.Parse(typeof(SROrganizationType), v));
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
