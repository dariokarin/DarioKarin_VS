﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CheapestFlightSearch.Entity.Model.Amadeus
{
    public class SearchResult
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }

        [JsonPropertyName("dictionaries")]
        public Dictionaries Dictionaries { get; set; }
    }
}
