using TipsOnPoints.Models;

namespace TipsOnPoints2.Models.Infra.Interfaces
{
    public interface ICardTipRepository
    {
        void Add(CardTips card);
        List<CardTips> Get();
    }
}