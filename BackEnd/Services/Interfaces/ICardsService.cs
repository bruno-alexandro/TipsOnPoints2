using TipsOnPoints.Models;
namespace TipsOnPoints2.Services.Interfaces
{
    public interface ICardsService
    {
        Task<string> GetNewCard();
        public void SaveCardToDb(ApiResponse dataFromOpenAi);
    }
}