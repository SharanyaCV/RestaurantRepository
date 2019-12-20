using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestaurantApplication3.Repository;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace RestaurantApplication3.Controllers
{
    public class EventsController : Controller
    {
        EventsRepository eventsRepositoryObj = new EventsRepository(new EventsContext());

        // GET: Appointments
        //public ActionResult Index()
        //{
        //    var events = eventsRepositoryObj.FindAll();
        //    return View(events);
        //}
        public ActionResult GetEventsList()
        {
            List<Events> eventsList = eventsRepositoryObj.GetEvents().ToList();

            try
            {
                return View(eventsList);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Events/Edit")]
        public ActionResult Create(Events events)
        {
            Events createEvent = eventsRepositoryObj.CreateEvent(events);
            eventsRepositoryObj.Save();
            return RedirectToAction("GetEventsList");

        }

        public ActionResult Edit(int id)
        {
            Events events = eventsRepositoryObj.GetEventsByID(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }
        [HttpPost]

        public ActionResult Edit(Events events)
        {
            if (ModelState.IsValid)
            {
                eventsRepositoryObj.EditEvent(events);
                eventsRepositoryObj.Save();
                return RedirectToAction("GetEventsList");
            }
            return View(events);
        }
        public ActionResult Details(int id)
        {
            Events events = eventsRepositoryObj.GetEventsByID(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }
        public ActionResult Delete(int id)
        {
            Events events = eventsRepositoryObj.GetEventsByID(id);
            if (events == null)
            {
                return HttpNotFound();
            }
            return View(events);
        }
        [HttpPost]

        public ActionResult Delete(Events events)
        {
            Events removeEvents = eventsRepositoryObj.DeleteEvent(events);
            eventsRepositoryObj.Save();
            return RedirectToAction("GetEventsList");
        }

        //[HttpPost]
        //public ActionResult SendMAilToUser(Events events)
        //{
        //    string SenderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
        //    string SenderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPassword"].ToString();



        //    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //    client.EnableSsl = true;
        //    client.Timeout = 100000;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = false;
        //    client.Credentials = new NetworkCredential(SenderEmail, SenderPassword);



        //    using (MailMessage mailMessage = new MailMessage(SenderEmail, events.))
        //    {
        //        mailMessage.Subject = events.ESubject;
        //        mailMessage.Body = events.Ebody;
        //        mailMessage.IsBodyHtml = true;
        //        mailMessage.BodyEncoding = UTF8Encoding.UTF8;
        //        //client.Send(mailMessage);
        //        ViewBag.Message = "Email sent.";
        //    }



        //    return View();



        //}




    }
}