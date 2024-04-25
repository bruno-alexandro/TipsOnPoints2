using TipsOnPoints.Models;
namespace TipsOnPoints.Services
{
    public interface ICardsService
    {
        Task<string> GetNewCard(Theme theme); 
        public void SaveCardToDb (ApiResponse dataFromOpenAi);
    }
}