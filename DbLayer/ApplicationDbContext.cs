using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Username=postgres;Password=SilkWay-Admin;Host=localhost;Port=5432;Database=RExpDb;");
        }

        //public virtual DbSet<Report> Reports { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<Address> Address { get; set; }
        //public virtual DbSet<Contact> Contacts { get; set; }
        //public virtual DbSet<Contractor> Contractors { get; set; }
        //public virtual DbSet<Expert> Experts { get; set; }
        //public virtual DbSet<ExpertTask> ExpertTasks { get; set; }
    }
}
