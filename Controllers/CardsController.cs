using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Moderation;
using TipsOnPoints.Services;

namespace TipsOnPoints.Controllers
{

    [ApiController]
    [Route("[controller]")]    
    public class CardsController : ControllerBase
    {
        public readonly ILogger<CardsController> _logger;
        //public readonly IOpenAiService _openAiService;
        public readonly ICardsService _cardsService;

        public CardsController(ILogger<CardsController> logger, ICardsService cardsService)
        {
            _logger = logger;
            _cardsService = cardsService;
        }

        [HttpGet]
        [Route("GetNewCard")]
        public async Task<IActionResult> GetNewCard(){
            //var text = "você é um oraculo que sabe tudo sobre lugares famosos no mundo, você consegue escolher um lugar e dar 10 dicas para que uma pessoa com conhecimento baixo sobre esse lugar consiga acertar que lugar é baseado nas suas dicas sem que você mensione ele. Baseado nesse contexto escolha um lugar, liste de 1 a 10 e no final escreva: Resposta: (aqui você coloca a resposta). Coloque somente a lista e a resposta, nada mais";
            var result = await _cardsService.GetNewCard();
            return Ok(result);
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }
    }
}