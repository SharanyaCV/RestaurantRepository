using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestaurantApplication3.Repository;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;

namespace RestaurantApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository empRepositoryObj = new EmployeeRepository(new EmployeeContext());

        public ActionResult GetEmployeeList()
        {
            List<Employee> employeeList = empRepositoryObj.GetEmployee().ToList();

            try
            {
                return View(employeeList);
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
        [Route("Employee/Edit")]
        public ActionResult Create(Employee employee)
        {
            Employee createEmployee = empRepositoryObj.CreateEmployee(employee);
            empRepositoryObj.Save();
            return RedirectToAction("GetEmployeeList");

        }
        public ActionResult Edit(int id)
        {
            Employee employee = empRepositoryObj.GetEmployeeByID(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]

        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                empRepositoryObj.EditEmployee(employee);
                empRepositoryObj.Save();
                return RedirectToAction("GetEmployeeList");
            }
            return View(employee);
        }
        public ActionResult Details(int id)
        {
            Employee employee = empRepositoryObj.GetEmployeeByID(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        public ActionResult Delete(int id)
        {
            Employee employee = empRepositoryObj.GetEmployeeByID(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            Employee removeEmployee = empRepositoryObj.DeleteEmployee(employee);
            empRepositoryObj.Save();
            return RedirectToAction("GetEmployeeList");
        }



    }
}