using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;

namespace RestaurantApplication3.Context.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            //Primary key
            this.HasKey(t => t.ID);
            //Properties
            this.Property(t => t.FirstName).HasMaxLength(80);
            this.Property(t => t.LastName).HasMaxLength(80);
            this.Property(t => t.Job).HasMaxLength(20);
            //table column mapping
            this.ToTable("Employee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Job).HasColumnName("Job");


        }
    }
}