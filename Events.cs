using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantAPI.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        
       // [ForeignKey("EventTypes")]
        public Int64 EventTypeId { get; set; }
       
       
        public DateTime? EventDateTime { get; set; }

       // public Customer customers { get; set; }
        public EventTypes EventTypesRecord { get; set; }
    
    }
}