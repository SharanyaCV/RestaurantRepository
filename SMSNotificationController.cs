using RestaurantApplication3.Models;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using RestaurantApplication3.Repository;

namespace RestaurantApplication3.Web.Controllers
{
    public class SMSNotificationController : Controller
    {
        private readonly EventsRepository _repository;

        public SMSNotificationController() : this(new EventsRepository()) { }

        public SMSNotificationController(EventsRepository repository)
        {
            _repository = repository;
        }

        public SelectListItem[] Timezones
        {
            get
            {
                var systemTimeZones = TimeZoneInfo.GetSystemTimeZones();
                return systemTimeZones.Select(systemTimeZone => new SelectListItem
                {
                    Text = systemTimeZone.DisplayName,
                    Value = systemTimeZone.Id
                }).ToArray();
            }
        }

        // GET: Events
        public ActionResult Index()
        {
            var events = _repository.GetEventsList();
            return View(events);
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var events = _repository.GetEventsByID(id.Value);
            if (events == null)
            {
                return HttpNotFound();
            }

            return View(events);
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            ViewBag.Timezones = Timezones;
            // Use an empty appointment to setup the default
            // values.
            var events = new Events
            {
                //Timezone = "Pacific Standard Time",
                EventDateTime = DateTime.Now
            };

            return View(events);
        }



        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,PhoneNumber,Time,Timezone")]Events events)
        {
            //events.CreatedAt = DateTime.Now;

            if (ModelState.IsValid)
            {
                _repository.CreateEvent(events);

                return RedirectToAction("Details", new { id = events.EventId });
            }

            return View("Create", events);
        }

        // GET: Appointments/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var events = _repository.GetEventsByID(id.Value);
            if (events == null)
            {
                return HttpNotFound();
            }

            ViewBag.Timezones = Timezones;
            return View(events);
        }

        // POST: /Appointments/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Name,PhoneNumber,Time,Timezone")]Events events)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateEvent(events);
                return RedirectToAction("Details", new { id = events.EventId });
            }
            return View(events);
        }

        // DELETE: Appointments/Delete/5
        [HttpDelete]
        public ActionResult Delete(Events events)
        {
            _repository.DeleteEvent(events);
            return RedirectToAction("Index");
        }
    }
}
    
