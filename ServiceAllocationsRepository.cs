using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

public class ServiceAllocationsRepository : IDisposable
{
    private ServiceAllocationsContext context;

    public ServiceAllocationsRepository(ServiceAllocationsContext context)
    {
        this.context = context;
    }
    public ServiceAllocationsRepository()
    {
        context = new ServiceAllocationsContext();
    }

    public IEnumerable<ServiceAllocations> GetServiceAllocations()
    {
        return context.ServiceAllocations.ToList();
    }
    public ServiceAllocations GetServiceAllocationsByID(int Id)
    {
        return context.ServiceAllocations.Find(Id);
    }

    public void InsertServiceAllocations(ServiceAllocations serviceAllocations)
    {
        context.ServiceAllocations.Add(serviceAllocations);
    }

    public void DeleteServiceAllocations(int Id)
    {
        ServiceAllocations serviceAllocations = context.ServiceAllocations.Find(Id);
        context.ServiceAllocations.Remove(serviceAllocations);
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