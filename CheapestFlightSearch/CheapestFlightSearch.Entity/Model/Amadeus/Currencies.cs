using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Currencies
    {
        [JsonPropertyName("EUR")]
        public string EUR { get; set; }
    }
}
