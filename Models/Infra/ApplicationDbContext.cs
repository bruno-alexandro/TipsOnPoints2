using Microsoft.EntityFrameworkCore;
using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }
        public DbSet<Card> Cards { get; set; }
    }
}