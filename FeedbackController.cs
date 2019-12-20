using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Repository;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;

namespace RestaurantApplication3.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        FeedbackRepository fbRepositoryObj = new FeedbackRepository(new FeedbackContext());
        public ActionResult GetFeedbackList()
        {

            List<Feedback> feedbackList = fbRepositoryObj.GetFeedback().ToList();
            try
            {
                return View(feedbackList);
            }
            catch (Exception e)
            {
                return Content("e.Message");
            }

        }
        public ActionResult Edit(int id)
        {
            Feedback feedback = fbRepositoryObj.GetFeedbackByID(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }
        [HttpPost]
        [Route("Feedback/Edit")]
        public ActionResult Edit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                fbRepositoryObj.EditFeedback(feedback);
                fbRepositoryObj.Save();
                return RedirectToAction("GetFeedbackList");
            }
            return View(feedback);
        }
        public ActionResult UpdateFeedback(Feedback feedback)
        {
            Feedback updateFeedback = fbRepositoryObj.UpdateFeedback(feedback);
            fbRepositoryObj.Save();
            return RedirectToAction("GetFeedbackList");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Feedback feedback)
        {
            Feedback createFeedback = fbRepositoryObj.CreateFeedback(feedback);
            fbRepositoryObj.Save();
            return RedirectToAction("GetFeedbackList");
        }
        public ActionResult Delete(int Id)
        {

            Feedback feedback = fbRepositoryObj.GetFeedbackByID(Id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }


        [HttpPost]
        [Route("Feedback/Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Feedback feedback)
        {
            Feedback removeFeedback = fbRepositoryObj.DeleteFeedback(feedback);

            fbRepositoryObj.Save();
            return RedirectToAction("GetFeedbackList");
        }
        public ActionResult Details(int id)
        {
            Feedback feedback = fbRepositoryObj.GetFeedbackByID(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }
    }
}