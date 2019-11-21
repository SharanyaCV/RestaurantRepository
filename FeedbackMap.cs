using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

namespace RestaurantAPI.Context.Mapping
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            //Primary Key
            this.HasKey(t => t.Id);
            //Property
            this.Property(t => t.ServiceAreas).HasMaxLength(40);

 

            //Table& column mapping
            this.ToTable("Feedback");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.VisitedDate).HasColumnName("VisitedDate");
            this.Property(t => t.StaffId).HasColumnName("StaffID");
            this.Property(t => t.ServiceAreas).HasColumnName("ServiceAreas");
            this.Property(t => t.FeedbackComment).HasColumnName("FeedbackComment");
            this.Property(t => t.ManagerComment).HasColumnName("ManagerComment");
            this.Property(t => t.IsReviewd).HasColumnName("IsReviewd");
            this.Property(t => t.ReviewedBy).HasColumnName("ReviewedBy");
            this.Property(t => t.ReviewDate).HasColumnName("ReviewDate");
            //relationship

            //this.HasOptional(t => t.Customer)
            //    .WithMany(t => t.Feedbacks)
            //    .HasForeignKey(d => d.CustomerID);

            this.HasRequired<Customer>(c => c.customer)
                .WithMany(f => f.feedbacks)
                .HasForeignKey<Int64>(c => c.CustomerID);
          
        }
    }
}
