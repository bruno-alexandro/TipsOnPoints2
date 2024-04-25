
using TipsOnPoints.Models;
using TipsOnPoints2.Models.Infra.Interfaces;

namespace TipsOnPoints.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly ApplicationDbContext _context;
        public CardRepository(ApplicationDbContext context){
            _context = context;
        }
        public void Add(Card card)
        {
            _context.Add(card);
            _context.SaveChanges();
        }

        public List<Card> Get()
        {
            return _context.Cards.ToList();
        }

    }
}