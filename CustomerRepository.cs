using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;
using RestaurantAPI.Context;

namespace RestaurantAPI.Repository
{
    public class CustomerRepository 
    {
        private CustomerContext context;
        public CustomerRepository(CustomerContext context)
        {
            this.context = context;
        }
        public CustomerRepository()
        {
            context = new CustomerContext();

        }
     

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
        public Customer GetCustomerByID(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public Customer InsertCustomer(Customer customer)
        {
            return context.Customers.Add(customer);
        }

        public Customer DeleteCustomer(int customerId)
        {
            Customer customer = context.Customers.Find(customerId);
          return  context.Customers.Remove(customer);
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
}