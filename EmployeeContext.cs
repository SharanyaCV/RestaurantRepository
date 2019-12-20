using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantApplication3.Context;
using RestaurantApplication3.Context.Mapping;
using RestaurantApplication3.Models;

namespace RestaurantApplication3.Models
{
    public class EmployeeContext : BaseContext<EmployeeContext>
    {
        public EmployeeContext() : base()
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());

        }
    }
}
