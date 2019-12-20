using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApplication3.Models
{
    public class ServiceAllocations
    {
        // [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string shiftstartTime { get; set; }
        public string shiftendtime { get; set; }
        [ForeignKey("ServiceAreas")]
        public Int64 ServiceId { get; set; }
        [Key]
        public Int64 Id { get; set; }
        public Employee employees { get; set; }
        public ServiceAreas ServiceArea { get; set; }
    }
}