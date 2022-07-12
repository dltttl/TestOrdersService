using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrdersServiceDAL.Models;
using OrdersServiceDAL.Repositories;
using OrdersServiceMVC.Models;

namespace OrdersServiceMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Order> Repository;

        public HomeController(IRepository<Order> repository)
        {
            Repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Repository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Clear()
        {
            await Repository.Clear();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Create(Order user)
        {
            await Repository.Add(user);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}