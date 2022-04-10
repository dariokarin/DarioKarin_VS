using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Links
    {
        [JsonPropertyName("self")]
        public string Self { get; set; }
    }
}
