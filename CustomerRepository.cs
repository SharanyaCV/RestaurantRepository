using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

namespace RestaurantApplication3.Repository
{
    public class CustomerRepository : IDisposable
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
        public void EditCustomer(Customer customer)
        {
            Customer editCustomer = context.Customers.Find(customer.Id);
            editCustomer.FirstName = customer.FirstName;
            editCustomer.LastName = customer.LastName;
            editCustomer.Email = customer.Email;
            editCustomer.PhoneNumber = customer.PhoneNumber;
            context.Entry(editCustomer).State = EntityState.Modified;
            context.SaveChanges();
            //context.Customers.Add(editCustomer);
        }
        public Customer UpdateCustomer(Customer customer)
        {
            return context.Customers.Add(customer);
        }
        public Customer CreateCustomer(Customer customer)
        {
            return context.Customers.Add(customer);
        }

        public Customer DeleteCustomer(Customer customer)
        {
            Customer removecustomer = context.Customers.Find(customer.Id);

            return context.Customers.Remove(removecustomer);
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
}