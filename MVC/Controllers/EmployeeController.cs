using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepo<Employee> _repo;

        // GET: HomeController1
        public EmployeeController(IRepo<Employee> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: HomeController1/Details/5
        public IActionResult Details(int id)
        {
            return View(_repo.Get(id));
        }

        // GET: HomeController1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
                _repo.Add(employee);
                return RedirectToAction("Index");
            
        }

        // GET: HomeController1/Edit/5
        public IActionResult Edit(int id)
        {
            return View(_repo.Get(id));
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
                _repo.Update(employee);
                return RedirectToAction("Index");
            
        }

        // GET: HomeController1/Delete/5
        public IActionResult Delete(int id)
        {
            return View(_repo.Get(id));
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
           
        }
    }
}
