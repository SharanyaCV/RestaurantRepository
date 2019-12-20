using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context.Mapping;

namespace RestaurantApplication3.Context
{

    public partial class ServiceAllocationContext : DbContext
    {
        static ServiceAllocationContext()
        {
            Database.SetInitializer<ServiceAllocationContext>(null);
        }
        public ServiceAllocationContext()
            : base("Name=CustomerContext")
        {
        }
        public DbSet<ServiceAllocations> ServiceAllocations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServiceAllocationsMap());

        }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<RestaurantApplication3.Models.ServiceAreas> ServiceAreas { get; set; }
    }
}
