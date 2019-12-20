using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

public class EventTypesRepository : IDisposable
{
    private EventTypesContext context;

    public EventTypesRepository(EventTypesContext context)
    {
        this.context = context;
    }
    public EventTypesRepository()
    {
        context = new EventTypesContext();
    }

    public IEnumerable<EventTypes> GetEventTypes()
    {
        return context.EventTypes.ToList();
    }
    public IEnumerable<EventTypes> GetEventTypesList()
    {
        return context.EventTypes.ToList();
    }
    public EventTypes GetEventTypesByID(int Id)
    {
        return context.EventTypes.Find(Id);
    }

    public void EditEventTypes(EventTypes eventTypes)
    {
        EventTypes editEventTypes = context.EventTypes.Find(eventTypes.Id);
        editEventTypes.Id = eventTypes.Id;
        editEventTypes.EventType = eventTypes.EventType;
        context.Entry(editEventTypes).State = EntityState.Modified;
        context.SaveChanges();

    }
    public EventTypes UpdateEventTypes(EventTypes eventTypes)
    {
        return context.EventTypes.Add(eventTypes);
    }
    public EventTypes CreateEventType(EventTypes eventTypes)
    {
        return context.EventTypes.Add(eventTypes);
    }
    public EventTypes DeleteEventType(EventTypes eventTypes)
    {
        EventTypes removeEventType = context.EventTypes.Find(eventTypes.Id);

        return context.EventTypes.Remove(removeEventType);
    }


    public void Save()
    {
        this.context.SaveChanges();
    }


    public void Dispose()
    {
        this.context.Dispose();
    }


}