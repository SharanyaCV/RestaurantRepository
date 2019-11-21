using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

namespace RestaurantAPI.Context.Mapping
{
    public class ServiceAllocationsMap : EntityTypeConfiguration<ServiceAllocations>
    {
        public ServiceAllocationsMap()
        {
            this.HasKey(t => t.Id);
            
            //Properties
            this.Property(t => t.ShiftDate);
            this.Property(t => t.shiftstartTime).HasMaxLength(10);
            this.Property(t => t.shiftendtime).HasMaxLength(10);
           
            //table column mapping
            this.ToTable("ServiceAllocations");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.ShiftDate).HasColumnName("ShiftDate");
            this.Property(t => t.shiftstartTime).HasColumnName("shiftstartTime");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.Id).HasColumnName("Id");
       
          //this.HasRequired<Employee>(c =>c.employees)
          //      .WithMany(f => f.ServiceAllocationsRecord)
          //      .HasForeignKey<int>(c => c.EmpId);

            this.HasRequired<ServiceArea>(c => c.ServiceArea)
                .WithMany(f => f.ServiceAllocationsRecord)
                .HasForeignKey<Int64>(c => c.ServiceId);
        }
    }
}