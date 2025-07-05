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


        /// <summary>
        /// Старые УДАЛИТЬ!!!
        /// public DbSet<ContractModel> Contracts { get; set; }
        /// public DbSet<ValuationAssignment> ValuationAssignments { get; set; }
        /// public DbSet<ReportRestrictionDetails> ReportRestrictionDetails { get; set; }
        /// public DbSet<ReportModel> Reports { get; set; }
        /// </summary>



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

            /// <summary>
            /// Старые удалить!!!
            /// </summary>
            //modelBuilder.Entity<ContractModel>()
            //    .Property(e => e.ContractType)
            //    .HasConversion(v => v.ToString(),
            //    v => (ContractType)Enum.Parse(typeof(ContractType), v));
            //modelBuilder.Entity<ContractModel>()
            //    .Property(e => e.StatusContract)
            //    .HasConversion(v => v.ToString(),
            //    v => (StatusType)Enum.Parse(typeof(StatusType), v));
            //modelBuilder.Entity<ContractModel>()
            //    .Property(e => e.PaymentStatusContract)
            //    .HasConversion(v => v.ToString(),
            //    v => (PaymentStatusType)Enum.Parse(typeof(PaymentStatusType), v));

            //modelBuilder.Entity<ValuationAssignment>()
            //    .Property(e => e.ValueOfType)
            //    .HasConversion(v => v.ToString(), 
            //    v => (ValueOfType)Enum.Parse(typeof(ValueOfType), v));
            //modelBuilder.Entity<ValuationAssignment>()
            //    .Property(e => e.ReportFormat)
            //    .HasConversion(v => v.ToString(),
            //    v => (ReportFormat)Enum.Parse(typeof(ReportFormat), v));
            //modelBuilder.Entity<ValuationAssignment>()
            //    .Property(e => e.CurrencyOfValue)
            //    .HasConversion(v => v.ToString(),
            //    v => (CurrencyOfValue)Enum.Parse(typeof(CurrencyOfValue), v));
            //modelBuilder.Entity<ValuationAssignment>()
            //    .Property(e => e.FinalValuePresentationForm)
            //    .HasConversion(v => v.ToString(),
            //    v => (FinalValuePresentationForm)Enum.Parse(typeof(FinalValuePresentationForm), v));

            //modelBuilder.Entity<ReportModel>()
            //    .Property(e => e.ReportType)
            //    .HasConversion(v => v.ToString(),
            //    v => (ReportType)Enum.Parse(typeof(ReportType), v));
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
