using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<GetData> GetDatas { get; set; }
        public DbSet<GetName> GetNames { get; set; }
    }
}
