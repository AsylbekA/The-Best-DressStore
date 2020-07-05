using DressStore.Models;
using Microsoft.EntityFrameworkCore;

namespace DressStore.DbContext
{
    public class DressStoreContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ExceptionDetail> ExceptionDetails { get; set; }

        public DressStoreContext(DbContextOptions<DressStoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExceptionDetail>().ToTable("Log_exceoprion");
            modelBuilder.Entity<Dress>().ToTable("Dress");
            modelBuilder.Entity<Company>().ToTable("Company");
        }
    }
}
