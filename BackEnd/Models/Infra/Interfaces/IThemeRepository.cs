using TipsOnPoints.Models;

namespace TipsOnPoints2.Models.Infra.Interfaces
{
    public interface IThemeRepository
    {
        void Add(Theme theme);
        List<Theme> Get();
    }
}