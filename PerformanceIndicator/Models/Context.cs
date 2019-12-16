using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id=1,Type = "Employee" },
                new Role { Id = 2, Type = "Manager" }
            );

            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "Kashif",CNIC="3740216028296" ,Designation="Clerk",salary=50000,Role_Id=1},
               new User { Id = 2, Name = "Atif", CNIC = "3740216028298", Designation = "Manager", salary = 50000, Role_Id = 2 }
           );
        }
    }
}
