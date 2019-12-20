using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantApplication3.Models
{
    public class ServiceAreas
    {
        [Key]
        public Int64 Id { get; set; }
        [MaxLength(40)]
        public string AreaName { get; set; }

        public ICollection<ServiceAllocations> ServiceAllocationsRecords { get; set; }
    }
}