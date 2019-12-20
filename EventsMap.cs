using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;

namespace RestaurantApplication3.Context.Mapping
{
    public class EventsMap : EntityTypeConfiguration<Events>
    {
        public EventsMap()
        {

            //Properties
            this.HasKey(t => t.EventId);


            //table column mapping
            this.ToTable("Events");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.EventTypeId).HasColumnName("EventTypeId");
            this.Property(t => t.EventDateTime).HasColumnName("EventDateTime");

            this.HasRequired(x => x.Customer).WithRequiredPrincipal(y => y.Events);
        }
    }
}