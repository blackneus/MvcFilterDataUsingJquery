using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3_MasterDetailsUI.Models;

namespace MVC3_MasterDetailsUI.Controllers
{
    public class NewEmployeeController : Controller
    {
        CompanyEntities objContext;

        public NewEmployeeController()
        {
            objContext = new CompanyEntities();
        }

        //
        // GET: /NewEmployee/

        public ActionResult Index()
        {
            var Employees = objContext.EmployeeInfoes.ToList();
            return View(Employees);
        }

        /// <summary>
        /// MEthod to Display the Filtered Data
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(EmployeeInfo emp)
        {
            List<EmployeeInfo> Employees;
            if (emp.EmpName != null)
            {
                Employees = (from Emp in objContext.EmployeeInfoes.ToList()
                             where Emp.EmpName.StartsWith(emp.EmpName)
                             select Emp).ToList();
            }
            else
            {
                Employees = objContext.EmployeeInfoes.ToList();
            }
            return PartialView("EmployeeInfo", Employees);
        }

        //
        // GET: /NewEmployee/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /NewEmployee/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /NewEmployee/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /NewEmployee/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /NewEmployee/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /NewEmployee/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /NewEmployee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
