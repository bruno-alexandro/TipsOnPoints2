using TipsOnPoints.Models;
using TipsOnPoints2.Models.Infra.Interfaces;
namespace TipsOnPoints.Repositories
{
    public class CardTipsRepository : ICardTipRepository
        {
            private readonly ApplicationDbContext _context;
            public CardTipsRepository(ApplicationDbContext context)
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