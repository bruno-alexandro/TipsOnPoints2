using Microsoft.Extensions.Options;
using TipsOnPoints.Configuration;
using TipsOnPoints.Models;
using TipsOnPoints2.Models.Infra.Interfaces;
using TipsOnPoints2.Services.Interfaces;

namespace TipsOnPoints.Services
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