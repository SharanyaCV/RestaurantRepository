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
    public class EventTypesContext : BaseContext<EventTypesContext>
    {
        public EventTypesContext() : base()
        {

        }
        public DbSet<EventTypes> EventTypes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventTypesMap());

        }
    }
}
