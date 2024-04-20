using Newtonsoft.Json;
namespace TipsOnPoints.Models
{
    public record ApiResponse([property: JsonProperty("dicas")] List<string> Dicas, [property: JsonProperty("resposta")] string Resposta);
}
