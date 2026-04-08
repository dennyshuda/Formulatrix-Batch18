using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data;

public class CompanyDbContext : DbContext {
    public DbSet<Employee> Employees { get; set; }
    public object Departments { get; internal set; }
    public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }
    public CompanyDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlite("Data Source=CompanyDatabase.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // ini harus di set unique disini?
        modelBuilder.Entity<Employee>(entity => {
            entity.HasIndex(e => e.Email).IsUnique();
        });

    }

}