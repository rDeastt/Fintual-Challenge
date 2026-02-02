using System.Text.Json.Serialization;

namespace FintualApi.Models.Externals
{
    public class FintualResponse
    {
        [JsonPropertyName("data")]
        public List<FintualDay> Data { get; set; } = new();
    }
}
