using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using RestaurantApplication3.Models;
using System;

namespace RestaurantApplication3.Context.Mapping
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            //Primary Key
            this.HasKey(t => t.Id);
            //Property
            this.Property(t => t.ServiceAreas);

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
            this.HasRequired<Customer>(c => c.customer)
                .WithMany(f => f.Feedbacks)
                .HasForeignKey<Int64>(c => c.CustomerID);



        }
    }
}