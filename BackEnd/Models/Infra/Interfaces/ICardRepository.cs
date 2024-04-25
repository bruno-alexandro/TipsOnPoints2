using TipsOnPoints.Models;

namespace TipsOnPoints2.Models.Infra.Interfaces
{
    public interface ICardRepository
    {
        void Add(Card card);
        List<Card> Get();
    }
}