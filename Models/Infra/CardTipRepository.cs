using TipsOnPoints.Models;
namespace TipsOnPoints.Repositories
{
    public class CardTipRepository : ICardTipRepository
        {
            private readonly ApplicationDbContext _context;
            public CardTipRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public void Add(CardTips cardTip)
            {
                _context.Add(cardTip);
                _context.SaveChanges();
            }

            public List<CardTips> Get()
            {
                return _context.CardTips.ToList();
            }
        }
}