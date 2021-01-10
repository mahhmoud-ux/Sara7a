using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tharaha.Models;

namespace tharaha.Controllers
{
    public class KudController : Controller
    {
        public MockRepository<Employee> Mocked { get; set; }

        public KudController(MockRepository<Employee> _MockRepo)
        {
            Mocked = _MockRepo;
        }

        // GET: KudController
        public ActionResult Index()
        {
            
            return View(Mocked.GetEmployees().ToList());
        }

        // GET: KudController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KudController/Create
        public ActionResult Create()
        {
            var x = new List<string>() { "iti", "HR", "Financial" };
            ViewBag.List = new SelectList(x);
            return View();
        }

        // POST: KudController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee r)
        {
            try
            {
                var x = new Employee()
                {
                    FName = r.FName,
                    LName = r.LName,
                    Department = r.Department,
                    imgUrl = r.imgUrl
                };
                Mocked.Add(x);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KudController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KudController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KudController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KudController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
