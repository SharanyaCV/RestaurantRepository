using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;
using RestaurantAPI.Context;

namespace RestaurantAPI.Repository
{
    public class EventsRepository
    {
        private EventsContext context;
        public EventsRepository(EventsContext context)
        {
            this.context = context;
        }
        public EventsRepository()
        {
            context = new EventsContext();

        }

        public IEnumerable<Events> GetEvents()
        {
            return context.Events.ToList();
        }
        public Events GetEventsByID(int eventsId)
        {
            return context.Events.Find(eventsId);
        }

        public Events InsertEvents(Events events)
        {
            return context.Events.Add(events);
        }

        public Events DeleteEvents(int eventsId)
        {
            Events events = context.Events.Find(eventsId);
            return context.Events.Remove(events);
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