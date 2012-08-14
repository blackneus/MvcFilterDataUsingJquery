using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3_MasterDetailsUI.Models;

namespace MVC3_MasterDetailsUI.Controllers
{
    public class EmployeeInfoController : Controller
    {
        CompanyEntities objContext;
        public EmployeeInfoController()
        {
            objContext = new CompanyEntities(); 
        }

        

        //
        // GET: /EmployeeInfo/

        public ActionResult Index()
        {
            var Employees = objContext.EmployeeInfoes.ToList(); 
            return View(Employees);
        }

        //
        // GET: /EmployeeInfo/Details/5
        //[HttpPost]
        public ActionResult Details(int id)
        {
            var Employee = objContext.EmployeeInfoes.Where(eno => eno.EmpNo == id).First();
           // return View(Employee); 
            return PartialView("EmployeeDetails",Employee);
        }

        //
        // GET: /EmployeeInfo/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EmployeeInfo/Create

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
        // GET: /EmployeeInfo/Edit/5
 
        public ActionResult Edit(int id)
        {
            var Employee = objContext.EmployeeInfoes.Where(eno => eno.EmpNo == id).First();
            return PartialView("EditEmployeeDetails", Employee);
        }

        //
        // POST: /EmployeeInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var Employee = objContext.EmployeeInfoes.Where(eno => eno.EmpNo == id).First();
                Employee.EmpName = collection[1].ToString();
                Employee.Salary = Convert.ToDecimal(collection[2]);
                Employee.DeptName = collection[3].ToString();
                Employee.Designation = collection[4].ToString();
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /EmployeeInfo/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /EmployeeInfo/Delete/5

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
