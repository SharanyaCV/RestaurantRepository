using System;
using System.Collections.Generic;
using RestaurantApplication3.Models;

namespace RestaurantApplication3
{
    public class UpcomingEvents
    {
        Events eventsObj = new Events();
        //public IEnumerable<EventTypes> FetchEventTypes() //returns the list of all events within notification duration
        //{
        //    EventTypesRepository eventTypesRepository = new EventTypesRepository();
        //    {
        //        var fetchedEvents = eventTypesRepository.GetEventTypesList();
        //        List<Events> fetchedEventsList = f => (f.DateTime - DateTime.Now);

        //        return fetchedEvents;
        //    }
        //}
        public List<DateTime> FetchEvents()
        {
            Double dblNotificationDuration = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["NotificationDuration"]);



            DateTime currentDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(365);



            List<DateTime> lstEventdateTime = new List<DateTime>();



            for (DateTime i = eventsObj.EventDateTime; i <= endDate; i = i.AddDays(1))
            {
                if ((i > currentDate) && (i <= currentDate.AddDays(dblNotificationDuration)))
                {
                    lstEventdateTime.Add(i);
                }



            }
            return lstEventdateTime;
        }
    }
}