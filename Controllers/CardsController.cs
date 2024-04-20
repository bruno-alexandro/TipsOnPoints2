using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TipsOnPoints.Models;
using TipsOnPoints.Repositories;
using TipsOnPoints.Services;

namespace TipsOnPoints.Controllers
{

    [ApiController]
    [Route("[controller]")]    
    public class CardsController : ControllerBase
    {
        public readonly ILogger<CardsController> _logger;
        public readonly ICardsService _cardsService;
        public readonly ICardRepository _cardRepository;

        public CardsController(ILogger<CardsController> logger, ICardsService cardsService, ICardRepository cardRepository)
        {
            _logger = logger;
            _cardsService = cardsService;
            _cardRepository = cardRepository;
        }

        [HttpPost]
        [Route("GetNewCard")]
        public async Task<IActionResult> GetNewCard([FromBody] Theme theme){
            //var text = "você é um oraculo que sabe tudo sobre lugares famosos no mundo, você consegue escolher um lugar e dar 10 dicas para que uma pessoa com conhecimento baixo sobre esse lugar consiga acertar que lugar é baseado nas suas dicas sem que você mensione ele. Baseado nesse contexto escolha um lugar, liste de 1 a 10 e no final escreva: Resposta: (aqui você coloca a resposta). Coloque somente a lista e a resposta, nada mais";
            var result = await _cardsService.GetNewCard(theme);
            ApiResponse? apiResponse = JsonSerializer.Deserialize<ApiResponse>(result);
            
            if (apiResponse != null)
                _cardsService.SaveCardToDb(apiResponse);

            return Ok(result);
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello World");
        }

        [HttpGet]
        public IActionResult GetAllCards()
        {
            return Ok(_cardRepository.Get());
        }

        [HttpPost]
        public IActionResult CreateCard([FromBody] Card card)
        {
            _cardRepository.Add(card);
            return Ok($"Carta criada: {card.Answer}");
        }
    }
}