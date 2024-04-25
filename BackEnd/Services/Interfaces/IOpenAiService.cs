namespace TipsOnPoints2.Services.Interfaces
{
    public interface IOpenAiService
    {
        Task<string> GetNewCard(string text);
    }
}