using TipsOnPoints2.Models;

namespace TipsOnPoints2.Models
{
    public interface ICardRepository
    {
        void Add(Card card);
        List<Card> Get();
    }
}