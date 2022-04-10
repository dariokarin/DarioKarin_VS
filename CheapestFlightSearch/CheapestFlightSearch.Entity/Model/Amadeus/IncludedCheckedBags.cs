using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class IncludedCheckedBags
    {
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("weightUnit")]
        public string WeightUnit { get; set; }
    }
}
