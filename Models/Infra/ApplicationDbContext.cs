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
        public DbSet<CardTips> CardTips { get; set; }
        public DbSet<Theme> Theme { get; set; }
        public DbSet<ThemeComplements> ThemeComplement { get; set; }
        
    }
}