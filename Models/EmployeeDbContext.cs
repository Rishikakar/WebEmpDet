using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


using System.Linq;
using System.Threading.Tasks;


namespace CompanyAssignment.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {


        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relationship>()
                .HasOne<Employee>(s => (Employee)(IEnumerable<Employee>)s.Employee)
                .WithMany(d => d.Relationships)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Relationship>()
               .HasOne<Project>(s => (Project)(IEnumerable<Project>)s.Project)
                .WithMany(d => d.Relationships)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
