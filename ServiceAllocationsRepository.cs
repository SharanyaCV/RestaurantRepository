using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

namespace RestaurantApplication3.Repository
{
    public class ServiceAllocationsRepository
    {
        private ServiceAllocationContext context;

        public ServiceAllocationsRepository(ServiceAllocationContext context)
        {
            this.context = context;
        }

        public ServiceAllocationsRepository()
        {
            // To do: Complete member initialization
        }

        public IEnumerable<ServiceAllocations> GetServiceAllocation()
        {
            return context.ServiceAllocations.ToList();
        }
        public IEnumerable<ServiceAllocations> GetServiceAllocationList()
        {
            return context.ServiceAllocations.ToList();
        }
        public ServiceAllocations GetServiceAllocationByID(int allocationId)
        {
            return context.ServiceAllocations.Find(allocationId);
        }
        public void EditServiceAllocation(ServiceAllocations serviceAllocations)
        {
         ServiceAllocations editServiceAlloc = context.ServiceAllocations.Find(serviceAllocations.Id);
            editServiceAlloc.EmpId = serviceAllocations.EmpId;
            editServiceAlloc.ShiftDate = serviceAllocations.ShiftDate;
            editServiceAlloc.shiftstartTime = serviceAllocations.shiftstartTime;
            editServiceAlloc.shiftendtime = serviceAllocations.shiftendtime;
            editServiceAlloc.ServiceId = serviceAllocations.ServiceId;
            editServiceAlloc.Id = serviceAllocations.Id;
            context.Entry(editServiceAlloc).State = EntityState.Modified;
            context.SaveChanges();
            //context.Customers.Add(editCustomer);
        }

        public ServiceAllocations InsertServiceAllocation(ServiceAllocations serviceAllocation)
        {
            return context.ServiceAllocations.Add(serviceAllocation);

        }
        public ServiceAllocations UpdateServiceAllocation(ServiceAllocations serviceAllocation)
        {
            return context.ServiceAllocations.Add(serviceAllocation);
        }

        public ServiceAllocations DeleteServiceAllocation(ServiceAllocations serviceAllocations)
        {
            ServiceAllocations serviceAllocation = context.ServiceAllocations.Find(serviceAllocations.Id);
            return context.ServiceAllocations.Remove(serviceAllocation);
        }


        public void Save()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }

    }
}