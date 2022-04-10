using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Operating
    {
        [JsonPropertyName("carrierCode")]
        public string CarrierCode { get; set; }
    }
}
