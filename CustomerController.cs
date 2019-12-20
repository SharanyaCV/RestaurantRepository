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
    public class CustomerController : Controller
    {
        CustomerRepository custRepositoryObj = new CustomerRepository(new CustomerContext());

        public ActionResult GetCustomerList()
        {

            List<Customer> customerList = custRepositoryObj.GetCustomers().ToList();
            try
            {
                return View(customerList);
            }
            catch (Exception e)
            {
                return Content("List Not Found");
            }

        }

        public ActionResult Edit(int id)
        {
            Customer customer = custRepositoryObj.GetCustomerByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        [HttpPost]
        [Route("Customer/Edit")]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                custRepositoryObj.EditCustomer(customer);
                custRepositoryObj.Save();
                return RedirectToAction("GetCustomerList");
            }
            return View();
        }

        public ActionResult UpdateCustomer(Customer customer)
        {
            Customer updateCustomer = custRepositoryObj.UpdateCustomer(customer);
            custRepositoryObj.Save();
            return RedirectToAction("GetCustomerList");
        }
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
      [Route("Customer/CreateCustomer")]
        public ActionResult CreateCustomer(Customer customer)
        {
            Customer createCustomer = custRepositoryObj.UpdateCustomer(customer);
            custRepositoryObj.Save();
            return RedirectToAction("GetCustomerList");
        }

        public ActionResult Delete(int Id)
        {

            Customer customer = custRepositoryObj.GetCustomerByID(Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        [HttpPost]
        [Route("Customer/Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer customer)
        {
            custRepositoryObj.DeleteCustomer(customer);

            custRepositoryObj.Save();
            return RedirectToAction("GetCustomerList");
        }

        public ActionResult Details(int id)
        {
            Customer customer = custRepositoryObj.GetCustomerByID(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }




    }
}