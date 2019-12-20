using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using RestaurantApplication3.Repository;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApplication3.Models
{
    // [Table("Feedback")]
    public class Feedback
    {
        // [ForeignKey("CustomerID")]
        [Key]
        public Int64 Id { get; set; }
        public Int64 CustomerID { get; set; }
        public DateTime? VisitedDate { get; set; }
        public int? StaffId { get; set; }
        [StringLength(40)]
        public string ServiceAreas { get; set; }
        public string FeedbackComment { get; set; }
        public string ManagerComment { get; set; }
        public bool IsReviewd { get; set; }
        public int? ReviewedBy { get; set; }
        public DateTime? ReviewDate { get; set; }

        public Customer customer { get; set; }
        //  [ForeignKey("FeedBackID")]
        // public ICollection<FeedbackScores> feedbackScoresRecord { get; set; }

    }
}