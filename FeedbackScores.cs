using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using RestaurantAPI.Models;
using RestaurantAPI.Context;
using RestaurantAPI.Repository;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{

    public class FeedbackScores
    {
        [Key]
        public Int64 Id { get; set; }
        public Int64 FeedBackID { get; set; }
        public int Type1 { get; set; }
        public int Type2 { get; set; }
        public int Type3 { get; set; }
        public int Type4 { get; set; }
        public int Type5 { get; set; }
        public decimal Overall { get; set; }

      public virtual Feedback feedback { get; set; }
    }
}