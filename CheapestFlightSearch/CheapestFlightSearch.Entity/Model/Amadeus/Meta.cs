using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class Meta
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
