using System.Text.Json.Serialization;

namespace BlazorWasmBrasilApiCep.Models
{
    public class Cep
    {
        [JsonPropertyName("cep")]
        public string Numero { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Neighborhood { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;
        public Ibge? Ibge { get; set; }
    }
}
