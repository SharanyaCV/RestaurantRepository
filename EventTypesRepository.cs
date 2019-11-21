using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository
{
    public class EventTypesRepository : IDisposable
    {
        private EventTypesContext context;
        public EventTypesRepository(EventTypesContext context)
        {
            this.context = context;
        }
        public EventTypesRepository()
        {
            context= new EventTypesContext();

        }

        public IEnumerable<EventTypes> GetEventTypes()
        {
            return context.EventTypes.ToList();
        }
        public EventTypes GetEventTypeByID(int eventTypeId)
        {
            return context.EventTypes.Find(eventTypeId);
        }

        public EventTypes InsertEventTypes(EventTypes eventTypes)
        {
            return context.EventTypes.Add(eventTypes);
        }

        public EventTypes DeleteEventTypes(int eventTypeId)
        {
            EventTypes eventTypes = context.EventTypes.Find(eventTypeId);
            return context.EventTypes.Remove(eventTypes);
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