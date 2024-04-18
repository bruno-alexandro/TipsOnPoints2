
namespace TipsOnPoints.Services
{
    public class CardsService : ICardsService
    {
        public readonly IOpenAiService _openAiService;
        public CardsService(IOpenAiService openApiService){
            _openAiService = openApiService;
        }
        public async Task<string> GetNewCard()
        {
            //var result = _openAiService.
            var text = "você é um oraculo que sabe tudo sobre lugares famosos no mundo, você consegue escolher um lugar e dar 10 dicas para que uma pessoa com conhecimento baixo sobre esse lugar consiga acertar que lugar é baseado nas suas dicas sem que você mensione ele. Baseado nesse contexto escolha um lugar, liste de 1 a 10 e no final escreva: Resposta: (aqui você coloca a resposta). Coloque somente a lista e a resposta, nada mais";
            var result = await _openAiService.GetNewCard(text);
            
            return result;
        }
    }
}