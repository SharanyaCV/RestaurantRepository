using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

namespace RestaurantAPI.Context.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            //Primary key
            this.HasKey(t => t.Id);
            //Properties
            this.Property(t => t.FirstName).HasMaxLength(80);
            this.Property(t => t.LastName).HasMaxLength(80);
            this.Property(t => t.Email).HasMaxLength(80);
            this.Property(t => t.PhoneNumber).HasMaxLength(80);
            //table column mapping
            this.ToTable("Customer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("EmailId");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
        }
    }
}