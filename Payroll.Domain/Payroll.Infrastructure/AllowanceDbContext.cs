using Microsoft.EntityFrameworkCore;
using Payroll.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Infrastructure
{
    public class AllowanceDbContext:DbContext
    {

        public AllowanceDbContext(DbContextOptions<AllowanceDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allowance>()
             .HasOne(a => a.Employee)
             .WithMany()
             .HasForeignKey(a => a.EmployeeID);

            modelBuilder.Entity<Allowance>()
                .HasOne(a => a.Department)
                .WithMany()
                .HasForeignKey(a => a.DepartmentId);

        }

        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
