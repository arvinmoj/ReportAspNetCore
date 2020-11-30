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
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }
        
        [Route("")]
        [Route("Index")]
        [Route("~/")]
        [HttpGet]
        public IActionResult Index()
        {
            var displaydata = _databaseContext.GetDatas.ToList();

            return View(displaydata);
        }

        [Route("Index")]
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

        [Route("GetNameByCode")]
        public IActionResult GetNameByCode(string code) 
        {
            var datalist = _databaseContext.GetNames.Where(u => u.Code == code).ToList();

            return new JsonResult(datalist);
        }
    }
}
