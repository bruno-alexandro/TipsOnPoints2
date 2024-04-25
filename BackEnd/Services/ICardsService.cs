using TipsOnPoints.Models;
namespace TipsOnPoints.Services
{
    public interface ICardsService
    {
        Task<string> GetNewCard(); 
        public void SaveCardToDb (ApiResponse dataFromOpenAi);
    }
}