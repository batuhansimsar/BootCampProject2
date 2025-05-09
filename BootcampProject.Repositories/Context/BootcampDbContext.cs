using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BootcampProject.Entities;
namespace BootcampProject.Repositories.Context
{
    //DbContext sınıfı, veritabanı ile bağlantıyı sağlar
    public class BootcampDbContext : DbContext
    { 
        public DbSet<Application> Applications { get; set; } //Application tablosunu temsil eder
        public DbSet<Bootcamp> bootcamps { get; set; } //Bootcamp tablosunu temsil eder

        public DbSet<Blacklist> Blacklists { get; set; } //Blacklist tablosunu temsil eder

        //DbContext yapılandırması yapılır, Fluent API ile.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API konfigürasyaonları burada yapılacak
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BootcampDbContext).Assembly)
        }

        //Constructor ile bağlantı stringi sağlanabilir
        public BootcampDbContext(DbContextOptions<BootcampDbContext> options) : base(options) { }
    }
}
