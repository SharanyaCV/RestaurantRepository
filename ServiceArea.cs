using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class ServiceArea
    {
        [Key]
        public Int64 Id { get; set; }
        public string AreaName { get; set; }
        public ICollection<ServiceAllocations> ServiceAllocationsRecord { get; set; }
    }
}