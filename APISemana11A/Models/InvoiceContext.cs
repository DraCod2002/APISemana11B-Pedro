using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APISemana11A.Models
{
    public class InvoiceContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrrollment> Enrrollments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-K4C4NU8\\SQLEXPRESSS; Database=APISemana11ADB; User ID=user1; Password=123456; Trust Server Certificate=True;");

        }
    }
}
