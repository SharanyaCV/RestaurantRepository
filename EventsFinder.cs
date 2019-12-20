using RestaurantApplication3.Models;
using RestaurantApplication3.Repository;
using System.Collections.Generic;

namespace RestaurantApplication3.Web.Workers
{
    internal class EventsFinder
    {
        private EventsRepository eventsRepository;
        private TimeConverter timeConverter;

        public EventsFinder(EventsRepository eventsRepository, TimeConverter timeConverter)
        {
            this.eventsRepository = eventsRepository;
            this.timeConverter = timeConverter;
        }
        public IEnumerable<EventTypes> FetchEventTypes(System.DateTime now)
        {
            EventTypesRepository eventTypesRepository = new EventTypesRepository();
            {
                var fetchedEvents = eventTypesRepository.GetEventTypesList();

                return (fetchedEvents);
            }
        }
    }
}