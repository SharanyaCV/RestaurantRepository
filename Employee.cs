using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace RestaurantAPI.Models
{
   // [Table("Employee")]
    public class Employee
    {


        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public ICollection<ServiceAllocations> ServiceAllocationsRecord { get; set; }
    }
}