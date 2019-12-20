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
    public class ServiceAllocationsController : Controller
    {
        ServiceAllocationsRepository saRepositoryObj = new ServiceAllocationsRepository(new ServiceAllocationContext());

        public ActionResult GetServiceAllocationList()
        {

            List<ServiceAllocations> serviceAllocList = saRepositoryObj.GetServiceAllocationList().ToList();
            try
            {
                return View(serviceAllocList);
            }
            catch (Exception e)
            {
                return Content("List Not Found");
            }

        }

        public ActionResult Edit(int id)
        {
            ServiceAllocations serviceAlloc = saRepositoryObj.GetServiceAllocationByID(id);
            if (serviceAlloc == null)
            {
                return HttpNotFound();
            }
            return View(serviceAlloc);
        }
        [HttpPost]
        [Route("ServiceAllocations/Edit")]
        public ActionResult Edit(ServiceAllocations serviceAlloc)
        {
            if (ModelState.IsValid)
            {
                saRepositoryObj.EditServiceAllocation(serviceAlloc);
                saRepositoryObj.Save();
                return RedirectToAction("GetServiceAllocationList");
            }
            return View();
        }

      
        public ActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        [Route("ServiceAllocations/CreateServiceAllocation")]
        public ActionResult CreateServiceAllocation(ServiceAllocations serviceAlloc)
        {
            ServiceAllocations createServiceAlloc = saRepositoryObj.UpdateServiceAllocation(serviceAlloc);
          saRepositoryObj.Save();
            return RedirectToAction("GetServiceAllocationList");
        }

        public ActionResult Delete(int Id)
        {
            ServiceAllocations serviceAlloc = saRepositoryObj.GetServiceAllocationByID(Id);
            if (serviceAlloc == null)
            {
                return HttpNotFound();
            }
            return View(serviceAlloc);
        }


        [HttpPost]
        [Route("ServiceAllocations/Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ServiceAllocations serviceAlloc)
        {
            saRepositoryObj.DeleteServiceAllocation(serviceAlloc);

            saRepositoryObj.Save();
            return RedirectToAction("GetServiceAllocationList");
        }

        public ActionResult Details(int id)
        {
            ServiceAllocations serviceAlloc = saRepositoryObj.GetServiceAllocationByID(id);
            if (serviceAlloc == null)
            {
                return HttpNotFound();
            }
            return View(serviceAlloc);
        }




    }
}