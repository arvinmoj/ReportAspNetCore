using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var displaydata = _databaseContext.GetDatas.ToList();
            return View(displaydata);
        }
    }
}
