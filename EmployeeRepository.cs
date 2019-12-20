using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using RestaurantApplication3.Models;
using RestaurantApplication3.Context;
using System.Data.Entity;

public class EmployeeRepository : IDisposable
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

    public IEnumerable<Employee> GetEmployee()
    {
        return context.Employees.ToList();
    }
    public IEnumerable<Employee> GetEmployeeList()
    {
        return context.Employees.ToList();
    }
    public Employee GetEmployeeByID(int Id)
    {
        return context.Employees.Find(Id);
    }

    public void EditEmployee(Employee employee)
    {
        Employee editEmployee = context.Employees.Find(employee.ID);
        editEmployee.ID = employee.ID;
        editEmployee.FirstName = employee.FirstName;
        editEmployee.LastName = employee.LastName;
        editEmployee.Job = employee.Job;


        context.Entry(editEmployee).State = EntityState.Modified;
        context.SaveChanges();

    }
    public Employee UpdateEmployee(Employee employee)
    {
        return context.Employees.Add(employee);
    }
    public Employee CreateEmployee(Employee employee)
    {
        return context.Employees.Add(employee);
    }
    public Employee DeleteEmployee(Employee employee)
    {
        Employee removeEmployee = context.Employees.Find(employee.ID);

        return context.Employees.Remove(removeEmployee);
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