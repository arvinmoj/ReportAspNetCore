using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReportAspNetCore.Models;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace ReportAspNetCore.Controllers
{
    public class PeopleController : Controller
    {
        private readonly Data.DatabaseContext _context;

        public PeopleController(Data.DatabaseContext context)
        {
            _context = context;
            StiLicense.LoadFromString("6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHl2AD0gPVknKsaW0un+3PuM6TTcPMUAWEURKXNso0e5OJN40hxJjK5JbrxU+NrJ3E0OUAve6MDSIxK3504G4vSTqZezogz9ehm+xS8zUyh3tFhCWSvIoPFEEuqZTyO744uk+ezyGDj7C5jJQQjndNuSYeM+UdsAZVREEuyNFHLm7gD9OuR2dWjf8ldIO6Goh3h52+uMZxbUNal/0uomgpx5NklQZwVfjTBOg0xKBLJqZTDKbdtUrnFeTZLQXPhrQA5D+hCvqsj+DE0n6uAvCB2kNOvqlDealr9mE3y978bJuoq1l4UNE3EzDk+UqlPo8KwL1XM+o1oxqZAZWsRmNv4Rr2EXqg/RNUQId47/4JO0ymIF5V4UMeQcPXs9DicCBJO2qz1Y+MIpmMDbSETtJWksDF5ns6+B0R7BsNPX+rw8nvVtKI1OTJ2GmcYBeRkIyCB7f8VefTSOkq5ZeZkI8loPcLsR4fC4TXjJu2loGgy4avJVXk32bt4FFp9ikWocI9OQ7CakMKyAF6Zx7dJF1nZw");
        }

        public IActionResult PrintPerson(int id)
        {
            return View();
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        public IActionResult PrintPage()
        {
            return View("PrintPage");
        }

        public IActionResult Print()
        {
            StiReport report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Reports/Report.mrt"));
            var persons = _context.GetDatas.ToList();
            report.RegData("dt", persons);
            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public IActionResult PrintPerople()
        {
            StiReport report = new StiReport();
            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/Reports/Report2.mrt"));
            var persons = _context.GetDatas.First();
            report.RegData("dt", persons);
            return StiNetCoreViewer.GetReportResult(this, report);
        }

        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
    }
}