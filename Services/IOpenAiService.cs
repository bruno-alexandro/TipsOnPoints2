namespace TipsOnPoints.Services
{
    public interface IOpenAiService
    {
        Task<string> GetNewCard(string text); 
    }
}