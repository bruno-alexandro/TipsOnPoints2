using TipsOnPoints2.Models;
namespace TipsOnPoints2.Services
{
    public interface ICardsService
    {
        Task<string> GetNewCard();
        public void SaveCardToDb(ApiResponse dataFromOpenAi);
    }
}