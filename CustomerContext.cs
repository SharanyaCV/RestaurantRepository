using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantAPI.Context.Mapping;
using RestaurantAPI.Models;
using RestaurantAPI.Context;

namespace RestaurantAPI.Models
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
    }
}
