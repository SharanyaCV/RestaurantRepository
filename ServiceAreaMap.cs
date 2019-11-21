using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;
using RestaurantAPI.Context;

namespace RestaurantAPI.Context.Mapping
{
    public class ServiceAreaMap : EntityTypeConfiguration<ServiceArea>
    {
        public ServiceAreaMap()
        {
            this.HasKey(t => t.Id);
            //Properties
           
            this.Property(t => t.AreaName).HasMaxLength(40);
          
            //table column mapping
            this.ToTable("ServiceArea");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
          
           
           
        }
    }
}