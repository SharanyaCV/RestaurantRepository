using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

namespace RestaurantApplication3.Repository
{
    public class EventsRepository: IDisposable

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
        public IEnumerable<Events> GetEventsList()
        {
            return context.Events.ToList();
        }
        public Events GetEventsByID(int eventId)
        {
            return context.Events.Find(eventId);
        }
        public Events CreateEvent(Events events)
        {
            return context.Events.Add(events);
        }
        public Events UpdateEvent(Events events)
        {
            return context.Events.Add(events);
        }
        public void EditEvent(Events events)
        {
            Events editEvent = context.Events.Find(events.EventId);
            editEvent.EventId = events.EventId;
            editEvent.EventTypeId = events.EventTypeId;
            editEvent.EventDateTime = events.EventDateTime;

            context.Entry(editEvent).State = EntityState.Modified;
            context.SaveChanges();

        }
        public Events DeleteEvent(Events events)
        {
            Events removeEvents = context.Events.Find(events.EventId);

            return context.Events.Remove(removeEvents);
        }


        public void Save()
        {
            context.SaveChanges();
        }


        public void Dispose()
        {
            context.Dispose();
        }

        //internal Events DeleteEvents(Events events)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Events> FindUpcomingEvents(TimeSpan nextNDays)
        {
            var now = DateTime.Now;
            var next = DateTime.Now.Add(nextNDays);
            // For debugging
            var events = context.Events.Where(x => x.EventDateTime > now && x.EventDateTime <= next).ToList();
            return events;
        }
    }
}