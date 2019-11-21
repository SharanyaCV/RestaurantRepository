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
    public class ServiceAllocationsContext : BaseContext<ServiceAllocationsContext>
    {
        public ServiceAllocationsContext(): base()
        {

        }
        public DbSet<ServiceAllocations> ServiceAllocations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ServiceAllocationsMap());
        }
    }
}
