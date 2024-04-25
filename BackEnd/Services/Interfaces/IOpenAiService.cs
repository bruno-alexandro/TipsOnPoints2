namespace TipsOnPoints2.Services
{
    public interface IOpenAiService
    {
        Task<string> GetNewCard(string text);
    }
}