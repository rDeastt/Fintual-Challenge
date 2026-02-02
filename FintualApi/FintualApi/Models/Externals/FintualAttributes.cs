using System.Text.Json.Serialization;

namespace FintualApi.Models.Externals
{
    public class FintualAttributes
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }
}
