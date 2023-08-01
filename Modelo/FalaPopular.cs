using System.Text.Json.Serialization;

namespace ConsumingBreakingBadAPI.Modelo
{
    internal class FalaPopular
    {
        [JsonPropertyName("quote")]
        public string? Fala { get; set; }
        [JsonPropertyName("author")]
        public string? Autor { get; set; }
    }

}
