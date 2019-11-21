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
    public class EventsContext :BaseContext<EventsContext>
    {
        public EventsContext(): base()
        {

        }
        public DbSet<Events> Events { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventsMap());

        }
    }
}
