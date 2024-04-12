using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Moderation;
using TipsOnPoints.Services;

namespace TipsOnPoints.Controllers
{

    [ApiController]
    [Route("[controller]")]    
    public class OpenApiController : ControllerBase
    {
        public readonly ILogger<OpenApiController> _logger;
        public readonly IOpenAiService _openAiService;

        public OpenApiController(ILogger<OpenApiController> logger, IOpenAiService openAiService)
        {
            _logger = logger;
            _openAiService = openAiService;
        }

        [HttpGet]
        [Route("GetNewCard")]
        public async Task<IActionResult> GetNewCard(){
            var text = "você é um oraculo que sabe tudo sobre lugares famosos no mundo, você consegue escolher um lugar e dar 10 dicas para que uma pessoa com conhecimento baixo sobre esse lugar consiga acertar que lugar é baseado nas suas dicas sem que você mensione ele. Baseado nesse contexto escolha um lugar, liste de 1 a 10 e no final escreva: Resposta: (aqui você coloca a resposta). Coloque somente a lista e a resposta, nada mais";
            var result = await _openAiService.GetNewCard(text);
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