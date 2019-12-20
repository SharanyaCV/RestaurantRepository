using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestaurantApplication3.Repository;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;

namespace RestaurantApplication3.Controllers
{
    public class EventTypesController : Controller
    {
        EventTypesRepository eventTypesRepositoryObj = new EventTypesRepository(new EventTypesContext());

        public ActionResult GetEventTypesList()
        {
            List<EventTypes> EventTypesList = eventTypesRepositoryObj.GetEventTypes().ToList();

            try
            {
                return View(EventTypesList);
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
        [Route("EventTypes/Edit")]
        public ActionResult Create(EventTypes eventTypes)
        {
            EventTypes createEventTypes = eventTypesRepositoryObj.CreateEventType(eventTypes);
            eventTypesRepositoryObj.Save();
            return RedirectToAction("GetEventTypesList");

        }
        public ActionResult Edit(int id)
        {
            EventTypes eventTypes = eventTypesRepositoryObj.GetEventTypesByID(id);
            if (eventTypes == null)
            {
                return HttpNotFound();
            }
            return View(eventTypes);
        }
        [HttpPost]

        public ActionResult Edit(EventTypes eventTypes)
        {
            if (ModelState.IsValid)
            {
                eventTypesRepositoryObj.EditEventTypes(eventTypes);
                eventTypesRepositoryObj.Save();
                return RedirectToAction("GetEventTypesList");
            }
            return View(eventTypes);
        }
        public ActionResult Details(int id)
        {
            EventTypes eventTypes = eventTypesRepositoryObj.GetEventTypesByID(id);
            if (eventTypes == null)
            {
                return HttpNotFound();
            }
            return View(eventTypes);
        }
        public ActionResult Delete(int id)
        {
            EventTypes eventTypes = eventTypesRepositoryObj.GetEventTypesByID(id);
            if (eventTypes == null)
            {
                return HttpNotFound();
            }
            return View(eventTypes);
        }
        [HttpPost]
        [Route("EventTypes/Delete")]
        public ActionResult Delete(EventTypes eventTypes)
        {
            EventTypes removeEventTypes = eventTypesRepositoryObj.DeleteEventType(eventTypes);
            eventTypesRepositoryObj.Save();
            return RedirectToAction("GetEventTypesList");
        }




    }
}