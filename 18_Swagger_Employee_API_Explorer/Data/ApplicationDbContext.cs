using _18_Swagger_Employee_API_Explorer.Models;
using Microsoft.EntityFrameworkCore;

namespace _18_Swagger_Employee_API_Explorer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsRequired();
            modelBuilder.Entity<Employee>()
                .Property(e => e.Department)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
