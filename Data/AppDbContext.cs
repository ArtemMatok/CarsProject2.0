using Microsoft.EntityFrameworkCore;
using ProjectCarsTheLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarsTheLast.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Car>? Cars { get; set; }    
        public DbSet<Additional>? Additionals { get; set; }
        public DbSet<Salary>? Salaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectCars;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
