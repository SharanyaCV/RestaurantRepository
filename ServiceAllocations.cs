using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class ServiceAllocations
    {
       // [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string shiftstartTime { get; set; }
        public string shiftendtime { get; set; }
        [ForeignKey("ServiceArea")]
        public Int64 ServiceId { get; set; }
        [Key]
        public Int64 Id { get; set; }
        public  Employee employees { get; set; }
        public  ServiceArea ServiceArea { get; set; }
    }
}