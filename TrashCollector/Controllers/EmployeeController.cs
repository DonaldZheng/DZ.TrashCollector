﻿using Microsoft.AspNetCore.Http;
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
                return RedirectToAction(nameof(Create));
            }
            //string currentDayOfWeek = DateTime.Now.DayOfWeek.ToString();
            //var customersSameZip = _context.Customers.Where(c => c.ZipCode == employee.Zipcode && c.PickUpDay == currentDayOfWeek).ToList();

            // do this if DateTime is null
            //var customersSameZip = _context.Customers.Where(c => c.ZipCode == employee.Zipcode && (c.PickUpDay == currentDayOfWeek || c.OneTimePickUp.DayOfWeek.ToString() == currentDayOfWeek) && (!(c.SuspendStartDate < DateTime.Now && c.SuspendEndDate > DateTime.Now))).ToList();
            //return View(customersSameZip);

            string currentDayOfWeek = DateTime.Now.DayOfWeek.ToString();
            var customersSameZip = _context.Customers.Where(c => c.ZipCode == employee.Zipcode && c.PickUpDay == currentDayOfWeek).ToList(); // belong to same zip code and active customer pick up for the day
            var customersSuspended = customersSameZip.Where(c => c.SuspendStartDate.ToString() == currentDayOfWeek && c.SuspendEndDate.ToString() == currentDayOfWeek).ToList(); // Start/ End suspend equals current day 
            var exception = customersSameZip.Except(customersSuspended); //same zip code expect customers that are suspended 
            return View(exception);
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
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
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

        public ActionResult ConfirmPickUp(int? id)
        {
            var customer = _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}