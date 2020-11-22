using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReportAspNetCore.Models
{
    public class ReportAspNetCoreContext : DbContext
    {
        public ReportAspNetCoreContext (DbContextOptions<ReportAspNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ReportAspNetCore.Models.Person> Person { get; set; }
    }
}
