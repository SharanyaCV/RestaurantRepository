using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

public class ServiceAreaRepository : IDisposable
{
    private ServiceAreaContext context;

    public ServiceAreaRepository(ServiceAreaContext context)
    {
        this.context = context;
    }

    public IEnumerable<ServiceArea> GetServiceAreas()
    {
        return context.ServiceAreas.ToList();
    }
    public ServiceArea GetServiceAreasByID(int Id)
    {
        return context.ServiceAreas.Find(Id);
    }

    public ServiceArea InsertServiceArea(ServiceArea serviceAreas)
    {
       return context.ServiceAreas.Add(serviceAreas);
    }

    public ServiceArea DeleteServiceAreas(int Id)
    {
        ServiceArea serviceAreas = context.ServiceAreas.Find(Id);
      return  context.ServiceAreas.Remove(serviceAreas);
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