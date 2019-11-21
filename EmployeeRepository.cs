using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantAPI.Models;

namespace RestaurantAPI.Repository
{
    public class EmployeeRepository 
    {
        private EmployeeContext context;
        public EmployeeRepository(EmployeeContext context)
        {
            this.context = context;
        }
        public EmployeeRepository()
        {
            context = new EmployeeContext();

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
        public Employee GetEmployeeByID(int employeeId)
        {
            return context.Employees.Find(employeeId);
        }

        public Employee InsertEmployee(Employee employee)
        {
            return context.Employees.Add(employee);
        }

        public Employee DeleteEmployee(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            return context.Employees.Remove(employee);
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