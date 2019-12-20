using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

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

    public void EditFeedback(Feedback feedback)
    {
        Feedback editFeedback = context.Feedbacks.Find(feedback.Id);
        editFeedback.Id = feedback.Id;
        editFeedback.CustomerID = feedback.CustomerID;
        editFeedback.VisitedDate = feedback.VisitedDate;
        editFeedback.StaffId = feedback.StaffId;
        editFeedback.ServiceAreas = feedback.ServiceAreas;
        editFeedback.FeedbackComment = feedback.FeedbackComment;
        editFeedback.ManagerComment = feedback.ManagerComment;
        editFeedback.IsReviewd = feedback.IsReviewd;
        editFeedback.ReviewedBy = feedback.ReviewedBy;
        editFeedback.ReviewDate = feedback.ReviewDate;

        context.Entry(editFeedback).State = EntityState.Modified;
        context.SaveChanges();

    }
    public Feedback UpdateFeedback(Feedback feedback)
    {
        return context.Feedbacks.Add(feedback);
    }
    public Feedback CreateFeedback(Feedback feedback)
    {
        return context.Feedbacks.Add(feedback);
    }
    public Feedback DeleteFeedback(Feedback feedback)
    {
        Feedback removeFeedback = context.Feedbacks.Find(feedback.Id);

        return context.Feedbacks.Remove(removeFeedback);
    }


    public void Save()
    {
        this.context.SaveChanges();
    }


    public void Dispose()
    {
        this.context.Dispose();
    }
}