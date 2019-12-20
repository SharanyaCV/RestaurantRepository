using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Ajax.Utilities;
namespace RestaurantApplication3.Models
{
    public class Events
    {
        [NotMapped]
        public static int ReminderTime = 30;
        [Key]
        public Int64 EventId { get; set; }

        [ForeignKey("EventType")]
        public Int64 EventTypeId { get; set; }

        public DateTime EventDateTime { get; set; }

        [ForeignKey("Customer")]
        public Int64 CustomerId { get; set; }
        public Customer Customer { get; set; }
        public EventTypes EventType { get; set; }
        //public EventTypes EventTypesRecord { get; set; }
        //public string Timezone { get; internal set; }
        //public DateTime CreatedAt { get; internal set; }
        //public object PhoneNumber { get; internal set; }
        //public object Name { get; internal set; }
        //public object Time { get; internal set; }
    }
}