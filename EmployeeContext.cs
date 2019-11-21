using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantAPI.Context;
using RestaurantAPI.Context.Mapping;
using RestaurantAPI.Models;

namespace RestaurantAPI.Models
{
    public class EmployeeContext : BaseContext<EmployeeContext>
    {
        public EmployeeContext(): base()
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());

        }
    }
}
