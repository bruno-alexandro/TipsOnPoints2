using TipsOnPoints2.Models;

namespace TipsOnPoints2.Services
{
    public class ThemeService : IThemeService
    {
        public readonly IThemeRepository _themeRepository;
        public ThemeService(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }
        public Theme GetSortedTheme()
        {
            var allThemes = _themeRepository.Get();
            int randomIndex = new Random().Next(allThemes.Count);
            return allThemes[randomIndex];
        }
    }
}