using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using RestaurantApplication3.Models;
using System;

namespace RestaurantApplication3.Context.Mapping
{
    public class ServiceAllocationsMap : EntityTypeConfiguration<ServiceAllocations>
    {
        public ServiceAllocationsMap()
        {
            this.HasKey(s => s.Id);

            this.Property(s => s.EmpId);
            this.Property(s => s.ShiftDate);
            this.Property(s => s.shiftendtime);
            this.Property(s => s.shiftstartTime);
            this.Property(s => s.ServiceId);

            this.ToTable("ServiceAllocations");
            this.Property(s => s.Id).HasColumnName("Id");
            this.Property(s => s.EmpId).HasColumnName("EmpId");
            this.Property(s => s.ShiftDate).HasColumnName("ShiftDate");
            this.Property(s => s.shiftendtime).HasColumnName("shiftendtime");
            this.Property(s => s.shiftstartTime).HasColumnName("shiftstartTime");
            this.Property(s => s.ServiceId).HasColumnName("ServiceId");

            this.HasRequired<Employee>(c => c.employees)
                .WithMany(f => f.ServiceAllocationsRecord)
                .HasForeignKey<int>(c => c.EmpId);

            this.HasRequired<ServiceAreas>(c => c.ServiceArea)
                .WithMany(f => f.ServiceAllocationsRecords)
                .HasForeignKey<Int64>(c => c.ServiceId);



        }


    }
}