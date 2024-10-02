using Microsoft.AspNetCore.Mvc;
using TipsOnPoints2.Models;
using TipsOnPoints2.Services;

namespace TipsOnPoints.Controllers
{

    [ApiController]
    [Route("[controller]")]    
    public class ThemeController : ControllerBase
    {
        public readonly ILogger<ThemeController> _logger;
        public readonly IThemeService _themesService;
        public readonly IThemeRepository _themeRepository;

        public ThemeController(ILogger<ThemeController> logger, IThemeService themeService, IThemeRepository themeRepository)
        {
            _logger = logger;
            _themesService = themeService;
            _themeRepository = themeRepository;
        }

        [HttpGet]
        public IActionResult GetAllThemes()
        {
            return Ok(_themeRepository.Get());
        }

        [HttpPost]
        public IActionResult CreateTheme([FromBody] Theme theme)
        {
            _themesService.CreateTheme(theme);
            return Ok(theme);
        }
    }
}