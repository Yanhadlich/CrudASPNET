using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Office> Offices { get; set; }
    }
}