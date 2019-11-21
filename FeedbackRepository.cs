using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;


public class FeedbackRepository : IDisposable
{
    private FeedbackContext context;

    public FeedbackRepository(FeedbackContext context)
    {
        this.context = context;
    }
    public FeedbackRepository()
    {
        context = new FeedbackContext();
    }

    public IEnumerable<Feedback> GetFeedback()
    {
        return context.Feedbacks.ToList();
    }
    public Feedback GetFeedbackByID(int Id)
    {
        return context.Feedbacks.Find(Id);
    }

    public Feedback InsertFeedback(Feedback feedback)
    {
      return  context.Feedbacks.Add(feedback);
    }

    public Feedback DeleteFeedback(int Id)
    {
        Feedback feedback = context.Feedbacks.Find(Id);
        return context.Feedbacks.Remove(feedback);
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