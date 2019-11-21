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
    public class FeedbackScoresMap : EntityTypeConfiguration<FeedbackScores>
    {
        public FeedbackScoresMap()
        {
            this.HasKey(t => t.Id);
            //Property
            this.Property(t => t.Type1);
            this.Property(t => t.Type2); 
            this.Property(t => t.Type3);
            this.Property(t => t.Type4);
            this.Property(t => t.Type5);
            this.Property(t => t.Overall);


            //Table& column mapping
            this.ToTable("FeedbackScores");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FeedBackID).HasColumnName("FeedBackID");
            this.Property(t => t.Type1).HasColumnName("Type1");
            this.Property(t => t.Type2).HasColumnName("Type2");
            this.Property(t => t.Type3).HasColumnName("Type3");
            this.Property(t => t.Type4).HasColumnName("Type4");
            this.Property(t => t.Type5).HasColumnName("Type5");
            this.Property(t => t.Overall).HasColumnName("Overall");
           
            //relationship



            this.HasRequired<Feedback>(c => c.feedback)
                   .WithMany(f => f.feedbackScoresRecord)
                   .HasForeignKey<Int64>(c => c.FeedBackID);
        }
    }
}
