
using TipsOnPoints.Models;
using TipsOnPoints2.Models.Infra.Interfaces;
using TipsOnPoints2.Services.Interfaces;

namespace TipsOnPoints.Services
{
    public class CardsService : ICardsService
    {
        public readonly IOpenAiService _openAiService;
        public readonly ICardRepository _cardRepository;
        public readonly ICardTipRepository _cardTipRepository;
        public readonly IThemeService   _themeService;

        // public readonly int _testThemeId = 1;
        // public readonly String _testTheme = "Lugares";
        // public readonly String _testSingleTheme = "Lugar";
        // public readonly int _testQtyTips = 50;
        // public readonly String _testThemeComplements = "Locais históricos, Cidades, Paises, Estados, Monumentos, Parques";
        //public Theme _theme;

        public CardsService(IOpenAiService openApiService, ICardRepository cardRepository, ICardTipRepository cardTipRepository, IThemeService themeService){
            _openAiService = openApiService;
            _cardRepository = cardRepository;
            _cardTipRepository = cardTipRepository;
            //_theme = new Theme();
            _themeService = themeService;
        }

        public string GetFullPromptText(Theme theme)
        {
            string themeComplements = theme.ThemeComplements?.Count == 0 || theme.ThemeComplements == null ? " quaisquer " : string.Join(", ", theme.ThemeComplements);

            string fullPrompText = $"Você é um oraculo que sabe tudo sobre {theme.PluralTheme} que podem ser {themeComplements} "+
                                   $"que são famosos no mundo. Sorteie um {theme.SingleTheme} qualquer "+
                                   $"e de {theme.QtyTips} dicas para que uma pessoa consiga adivinhar muito facilmente baseado nas suas dicas sem que você mensione ele. "+
                                   $"Me retorne um JSON com SEMPRE com as dicas e a resposta, somente o JSON e nada mais, no JSON as dicas virão como dicas: [], resposta: ";
            
            return fullPrompText;
        }
        public async Task<string> GetNewCard()
        {
            var fullPrompText = GetFullPromptText(_themeService.GetSortedTheme());
            var result = await _openAiService.GetNewCard(fullPrompText);
            return result; 
        }

        public void SaveCardToDb (ApiResponse dataFromOpenAi)
        {
            Card card = new Card
            {
                Answer = dataFromOpenAi.Resposta
            };
            _cardRepository.Add(card);

            foreach (var tip in dataFromOpenAi.Dicas)
            {
                var cardTip = new CardTips
                {
                    Tip = tip,
                    CardId = card.Id
                };

                _cardTipRepository.Add(cardTip);
            }
  
        }
    }
}