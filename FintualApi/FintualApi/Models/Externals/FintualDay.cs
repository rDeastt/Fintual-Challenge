using System.Text.Json.Serialization;

namespace FintualApi.Models.Externals
{
    public class FintualDay
    {
        [JsonPropertyName("attributes")]
        public FintualAttributes Attributes { get; set; } = new();
    }
}
