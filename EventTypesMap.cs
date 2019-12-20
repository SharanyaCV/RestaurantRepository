using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;

namespace RestaurantApplication3.Context.Mapping
{
    public class EventTypesMap : EntityTypeConfiguration<EventTypes>
    {
        public EventTypesMap()
        {
            //PrimaryKey
            this.HasKey(t => t.Id);
            this.Property(t => t.EventType);

            //table column mapping
            this.ToTable("EventTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EventType).HasColumnName("EventType");

        }
    }
}