using burada;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework

//Context : Db tabloları ile proje classlarını bağlamak
{
    public class CarRentalProjectContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRentalProject;Trusted_Connection=true");
        }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Databases=CarRentalProject;Trusted_Connection=true");
    //}

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
