using TipsOnPoints.Models;

namespace TipsOnPoints.Repositories
{
    public interface ICardTipRepository {
        void Add(CardTips card);
        List<CardTips> Get();
    }
}