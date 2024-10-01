using TipsOnPoints2.Models;
namespace TipsOnPoints2.Services
{
    public interface IThemeService
    {
        Theme GetSortedTheme();
        public Theme CreateTheme(Theme theme);

    }
}