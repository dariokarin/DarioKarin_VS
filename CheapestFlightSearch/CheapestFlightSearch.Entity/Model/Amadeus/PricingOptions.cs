using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class PricingOptions
    {
        [JsonPropertyName("fareType")]
        public List<string> FareType { get; set; }

        [JsonPropertyName("includedCheckedBagsOnly")]
        public bool IncludedCheckedBagsOnly { get; set; }
    }
}
