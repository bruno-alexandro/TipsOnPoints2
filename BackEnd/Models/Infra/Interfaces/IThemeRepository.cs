namespace TipsOnPoints2.Models
{
    public interface IThemeRepository
    {
        void Add(Theme theme);
        List<Theme> Get();
    }
}