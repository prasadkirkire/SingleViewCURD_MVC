using SingleViewCURD.Models;
using SingleViewCURD.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingleViewCURD.Controllers
{
    public class EmployeeController : Controller
    {
        SingleViewCURDContext db = new SingleViewCURDContext();
        // GET: Employee
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var emp = new EmployeeVM()
            {
                EmployeeList = db.EmployeeTbls.ToList()
            };
            return View(emp);
        }

        [HttpPost]
        public ActionResult Create(EmployeeVM employeeVM)
        {
            if (employeeVM.EmployeeSingle.EmployeeID == 0)
            {
                db.EmployeeTbls.Add(employeeVM.EmployeeSingle);
                db.SaveChanges();
                
            }
            else
            {
                //var rec = db.EmployeeTbls.Find(employeeVM.EmployeeSingle.EmployeeID);

                db.Entry(employeeVM.EmployeeSingle).State = EntityState.Modified;
                db.SaveChanges();
                
            }
            return RedirectToAction("Create");

        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            
            var emp = new EmployeeVM()
            {
                EmployeeList = db.EmployeeTbls.ToList(),
                EmployeeSingle = db.EmployeeTbls.Find(id)
            };
            return View("Create",emp);
        }

       

        [HttpGet]
        public ActionResult Details(Int64 id)
        {
            var emp = new EmployeeVM()
            {
                EmployeeList = db.EmployeeTbls.ToList(),
                EmployeeSingle = db.EmployeeTbls.Find(id)
            };
            return View("Create", emp);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec  = db.EmployeeTbls.Find(id);
            db.EmployeeTbls.Remove(rec);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
    }
}