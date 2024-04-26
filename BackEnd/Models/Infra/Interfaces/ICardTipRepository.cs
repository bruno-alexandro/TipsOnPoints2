namespace TipsOnPoints2.Models
{
    public interface ICardTipRepository
    {
        void Add(CardTips card);
        List<CardTips> Get();
    }
}