using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Repository;
using RestaurantAPI.Models;
using RestaurantAPI.Context;

namespace RestaurantAPI.Controllers
{
    public class RestaurantAPIController : ApiController
    {
        CustomerRepository custRepositoryObj = new CustomerRepository(new CustomerContext());

        [HttpGet]
        [Route("api/Customer/Get")]
        public IHttpActionResult GetCustomerList()
        {

            List<Customer> customerList = custRepositoryObj.GetCustomers().ToList();
            try
            {
                return Ok(customerList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("api/Customer/List")]
        public IHttpActionResult GetCustomerList([FromBody] Customer customer)
        {

            List<Customer> customerList = custRepositoryObj.GetCustomers().ToList();
            try
            {
                return Ok(customerList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Customer/Insert")]
        public IHttpActionResult InsertCustomerToList([FromBody]Customer customer)
        {
            Customer addCustomer = custRepositoryObj.InsertCustomer(customer);
            custRepositoryObj.Save();
            try
            {
                return Ok("Customer Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPost]
        [Route("api/Customer/Delete")]
        public IHttpActionResult Delete([FromBody]int customerId)
        {

            Customer customerList = custRepositoryObj.DeleteCustomer(customerId);
            custRepositoryObj.Save();
            try
            {
                return Ok("Customer deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        FeedbackRepository fbRepositoryObj = new FeedbackRepository(new FeedbackContext());

        [HttpGet]
        [Route("api/Feedback/Get")]
        public IHttpActionResult GetFeedbackList()
        {

            List<Feedback> feedbackList = fbRepositoryObj.GetFeedback().ToList();
            try
            {
             
                return Ok(feedbackList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Feedback/List")]
        public IHttpActionResult GetFeedbackList([FromBody] Feedback feedback)
        {

            List<Feedback> feedbackList = fbRepositoryObj.GetFeedback().ToList();
            try
            {
                return Ok(feedbackList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Feedback/Insert")]
        public IHttpActionResult InsertFeedbackToList([FromBody]Feedback feedback)
        {
            Feedback addFeedback = fbRepositoryObj.InsertFeedback(feedback);
            fbRepositoryObj.Save();
            try
            {
                return Ok("Feedback Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/Feedback/Delete")]
        public IHttpActionResult DeleteFeedback([FromBody]int Id)
        {

            Feedback feedbackList = fbRepositoryObj.DeleteFeedback(Id);
            fbRepositoryObj.Save();
            try
            {
                return Ok("Feedback deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        EmployeeRepository empRepositoryObj = new EmployeeRepository(new EmployeeContext());
        [HttpGet]
        [Route("api/Employee/Get")]
        public IHttpActionResult GetEmployeeList()
        {

            List<Employee> employeeList = empRepositoryObj.GetEmployees().ToList();
            try
            {
                return Ok(employeeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/Employee/List")]
        public IHttpActionResult GetEmployeeList([FromBody] Employee employee)
        {

            List<Employee> employeeList = empRepositoryObj.GetEmployees().ToList();
            try
            {
                return Ok(employeeList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/Employee/Insert")]
        public IHttpActionResult InsertEmployeeToList([FromBody]Employee employee)
        {
            Employee employeeList = empRepositoryObj.InsertEmployee(employee);
            empRepositoryObj.Save();
            try
            {
                return Ok("Employee Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/Employee/Delete")]
        public IHttpActionResult DeleteEmployee([FromBody]int Id)
        {

            Employee employeeList = empRepositoryObj.DeleteEmployee(Id);
            empRepositoryObj.Save();
            try
            {
                return Ok("Employee deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        EventTypesRepository eventTypesRepositoryObj = new EventTypesRepository(new EventTypesContext());

        [HttpGet]
        [Route("api/EventTypes/Get")]
        public IHttpActionResult GetEventTypesList()
        {

            List<EventTypes> eventTypesList = eventTypesRepositoryObj.GetEventTypes().ToList();
            try
            {

                return Ok(eventTypesList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/EventTypes/List")]
        public IHttpActionResult GetEventTypesList([FromBody] EventTypes eventTypes)
        {
          
            List<EventTypes> eventTypesList = eventTypesRepositoryObj.GetEventTypes().ToList();
            try
            {
                return Ok(eventTypesList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/EventTypes/Insert")]
        public IHttpActionResult InsertEventTypeToList([FromBody] EventTypes eventTypes)
        {
            EventTypes eventTypesList = eventTypesRepositoryObj.InsertEventTypes(eventTypes);
            eventTypesRepositoryObj.Save();
            try
            {
                return Ok("Event Type Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/EventTypes/Delete")]
        public IHttpActionResult DeleteEventType([FromBody]int Id)
        {

            EventTypes eventTypesList = eventTypesRepositoryObj.DeleteEventTypes(Id);
            eventTypesRepositoryObj.Save();
            try
            {
                return Ok("Event Type deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        ServiceAreaRepository serviceAreaRepositoryObj = new ServiceAreaRepository(new ServiceAreaContext());
        [HttpGet]
        [Route("api/ServiceArea/Get")]
        public IHttpActionResult GetServiceAreaList()
        {

            List<ServiceArea> serviceAreaList = serviceAreaRepositoryObj.GetServiceAreas().ToList();
            try
            {
                
                return Ok(serviceAreaList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/ServiceArea/List")]
        public IHttpActionResult GetServiceAreasList([FromBody] ServiceArea serviceArea)
        {

            List<ServiceArea> serviceAreaList = serviceAreaRepositoryObj.GetServiceAreas().ToList();
            try
            {
                return Ok(serviceAreaList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/ServiceArea/Insert")]
        public IHttpActionResult InsertServiceAreaToList([FromBody] ServiceArea serviceArea)
        {
            ServiceArea serviceAreaList = serviceAreaRepositoryObj.InsertServiceArea(serviceArea);
            eventTypesRepositoryObj.Save();
            try
            {
                return Ok("Service Area Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        [Route("api/ServiceArea/Delete")]
        public IHttpActionResult DeleteServiceArea([FromBody]int Id)
        {

            ServiceArea serviceAreaList = serviceAreaRepositoryObj.DeleteServiceAreas(Id);
            serviceAreaRepositoryObj.Save();
            try
            {
                return Ok("Service Area deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }


}

