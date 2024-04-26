
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
            string themeComplements = theme.ThemeComplements?.Count == 0 || theme.ThemeComplements == null ? " quaisquer " : string.Join(", ", theme.ThemeComplements.Select(tc => tc.Complements));

            //string fullPrompText = $"Você é um oraculo que sabe tudo sobre o tema: <{theme.PluralTheme}> que possui o(s) subtema(s):<{themeComplements}>. "+
            //                       $"Escolha um subtema aleatorio do tema mensionado, baseado nesta escolha, pegue um(a) do(a) subtema que seja famoso no mundo. "+
            //                       $"Me retorne {theme.QtyTips} dicas sobre este(a). Cada dica deve ter no mínimo 10 palavras e no maximo 30. Uma pessoa leiga sobre o assunto deve ser capaz de acertar a resposta. . "+
            //                       $"Me retorne um JSON com SEMPRE com as dicas e a resposta, somente o JSON e nada mais, no JSON as dicas virão como dicas: [], resposta: , escolha_do_subtema: ";

            string fullPrompText = $"Você é um oráculo com amplo conhecimento sobre o tema {theme.PluralTheme}, que abrange os seguintes subtemas: {themeComplements}. " +
                      $"Escolha aleatoriamente um desses subtemas para prosseguir. Com base nessa escolha, selecione uma entidade do subtema que seja amplamente reconhecido. " +
                      $"A seguir, gostaria de receber {theme.QtyTips} dicas sobre a entidade selecionada especificamente. " +
                      $"Cada dica deve ser formulada com entre 10 e 30 palavras, com o objetivo de ser compreensível para qualquer pessoa Brasileira, mesmo aquelas sem conhecimento prévio sobre a entidade. (as dicas não podem ser generalistas, ou seja, seja quase impossivel relacionar as dicas a mais de 2 entidades diferentes), (as dicas não podem ter relação umas com as outras), (nas dicas tambem pode conter nomes, caracteristicas, charadas, quebras-cabeças, expressões, ditados populares). " +
                      $"Por fim, espero que você me retorne um JSON estruturado contendo as dicas e a resposta. " +
                      $"O formato desse JSON deve ser o seguinte: {{\"dicas\": [...], \"resposta\": \"\", \"escolha_do_subtema\": \"\"}}.";

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