using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public interface IThemeRepository {
        void Add(Theme theme);
        List<Theme> Get();
    }
}