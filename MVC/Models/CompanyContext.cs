using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class CompanyContext : DbContext
    {

        public CompanyContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 101, Name = "Admin" },
                 new Department() { Id = 102, Name = "Developers" });
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Tim", Age = 21, DepartmentId = 101 },
                new Employee() { Id = 2, Name = "Jim", Age = 26, DepartmentId = 101 }
                );

        }
    }
}
