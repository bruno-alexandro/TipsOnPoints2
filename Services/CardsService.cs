
namespace TipsOnPoints.Services
{
    public class CardsService : ICardsService
    {
        public readonly IOpenAiService _openAiService;

        public readonly String _testTheme = "Lugares";
        public readonly String _testSingleTheme = "Lugar";
        public readonly int _testQtyTips = 50;
        public readonly String _testThemeComplements = "Locais históricos, Cidades, Paises, Estados, Monumentos, Parques";
        public readonly String _testCompleteText = "";
        public CardsService(IOpenAiService openApiService){
            _openAiService = openApiService;
            _testCompleteText = $"Você é um oraculo que sabe tudo sobre {_testTheme} que podem ser {_testThemeComplements} "+
                                $"que são famosos no mundo. Sorteie um {_testSingleTheme} qualquer "+
                                $"e de {_testQtyTips} dicas para que uma pessoa consiga adivinhar muito facilmente baseado nas suas dicas sem que você mensione ele. "+
                                $"Me retorne um JSON com as dicas e a resposta, somente o JSON e nada mais";
        }
        public async Task<string> GetNewCard()
        {
            var result = await _openAiService.GetNewCard(_testCompleteText);
            return result;
        }
    }
}