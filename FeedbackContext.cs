using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantApplication3.Context;
using RestaurantApplication3.Context.Mapping;
using RestaurantApplication3.Models;

namespace RestaurantApplication3.Models
{
    public class FeedbackContext : BaseContext<FeedbackContext>
    {

        public FeedbackContext() : base()
        {

        }
        public DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new FeedbackMap());
        }
    }
}
