using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public interface ICardRepository {
        void Add(Card card);
        List<Card> Get();
    }
}