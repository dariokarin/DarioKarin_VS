using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Carriers
    {
        [JsonPropertyName("PR")]
        public string PR { get; set; }
    }
}
