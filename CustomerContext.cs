using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantApplication3.Context.Mapping;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;

namespace RestaurantApplication3.Models
{
    public class CustomerContext : BaseContext<CustomerContext>
    {
        public CustomerContext() : base()
        {

        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());

        }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.Feedback> Feedbacks { get; set; }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.Events> Events { get; set; }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.EventTypes> EventTypes { get; set; }
    }
}
