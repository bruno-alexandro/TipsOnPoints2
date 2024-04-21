using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public interface ICardTipRepository {
        void Add(CardTips cardTips);
        List<CardTips> Get();
    }
}