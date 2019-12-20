using System;
using System.Collections.Generic;
using System.Drawing;
using RestaurantApplication3.Models;
using RestaurantApplication3.Repository;
using WebGrease.Css.Extensions;


namespace RestaurantApplication3.Web.Workers
{
    public class SendNotificationsJob
    {
        private const string MessageTemplate = "Hi {0}. Just a reminder that you have an event coming up at {1}.";
        
        public void Execute()
        {
            var twilioRestClient = new Domain.Twilio.RestClient();
            int days = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["NotificationDuration"]);

            AvailableEvents(days).ForEach(@event =>
                twilioRestClient.SendSmsMessage(
                @event.Customer.PhoneNumber,
                string.Format(MessageTemplate, @event.Customer.FirstName, @event.EventDateTime)));
        }

        private static IEnumerable<Events> AvailableEvents(int days)
        {
            using(var eventsRepository = new EventsRepository())
            {
                return eventsRepository.FindUpcomingEvents(TimeSpan.FromDays(days));
            }
        }
        public bool EventsFetch(Events events)
        {
            int years = DateTime.Now.Year - events.EventDateTime.Year;
            events.EventDateTime = events.EventDateTime.AddYears(years);
            Double notificationDuration = Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["NotificationDuration"]);
            DateTime check = DateTime.Now.AddDays(notificationDuration);

            if ((events.EventDateTime > DateTime.Now) && (events.EventDateTime < check))
            {
                return true; //return true if given eventDateTime falls in next 7 days .
            }
            else return false;

        }
        public 
       

    }
}
