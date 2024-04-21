
using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public class ThemeRepository : IThemeRepository
    {
        private readonly ApplicationDbContext _context;
        public ThemeRepository(ApplicationDbContext context){
            _context = context;
        }
        public void Add(Theme theme)
        {
            _context.Add(theme);
            _context.SaveChanges();
        }

        public List<Theme> Get()
        {
            return _context.Theme.ToList();
        }

    }
}