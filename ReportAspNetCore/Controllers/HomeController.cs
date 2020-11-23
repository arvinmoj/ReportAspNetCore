using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using ReportAspNetCore.Models;

namespace ReportAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var displaydata = _databaseContext.GetDatas.ToList();

            return View(displaydata);
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetData data)
        {

            if (ModelState.IsValid)
            {
                _databaseContext.Add(data);
                await _databaseContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
