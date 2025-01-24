using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Students> tbl_Students { get; set; }
        public DbSet<Teachers> tbl_Teachers { get; set; }

    }
}
