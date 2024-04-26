using Newtonsoft.Json;
namespace TipsOnPoints2.Models
{
    public record ApiResponse([property: JsonProperty("dicas")] List<string> Dicas, [property: JsonProperty("resposta")] string Resposta);
}
