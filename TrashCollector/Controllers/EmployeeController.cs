using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); // same as customer controller 
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            if (employee == null)
            {
                string currentDayOfWeek = DateTime.Now.DayOfWeek.ToString(); // need this to display current day of the week 
                var customerSameZipCode = _context.Customers.Where(c => c.ZipCode == employee.Zipcode).ToList();
                var customerSameDay = customerSameZipCode.Where(c => c.PickUpDate == currentDayOfWeek);
            }
            return View();
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var details = _context.Employees.Find(id);
            return View(details);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("Error!");
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var editEmployee = _context.Employees.Find(id);
            return View(editEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteEmployee = _context.Employees.Find(id);
            return View(deleteEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("Error!");
                return View();
            }
        }

        public ActionResult ChargeCustomer(int id)
        {
            var chargeId = _context.Customers.Find(id);
            return View(chargeId);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChargeCustomer(int id, Customer customer) // add it with delete, edit, detail - david 
        {
            try
            {
                // var
                customer.BalanceDue += 20;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("Error!");
                return View();

            }
        }
    }
}