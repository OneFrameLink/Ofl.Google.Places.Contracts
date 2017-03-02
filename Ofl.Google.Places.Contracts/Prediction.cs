using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Places
{
    public class Prediction
    {
        public string Description { get; set; }

        public string Id { get; set; }

        [JsonProperty("matched_substrings")]
        public IReadOnlyCollection<MatchedSubstring> MatchedSubstrings { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        public string Reference { get; set; }

        public IReadOnlyCollection<Term> Terms { get; set; }

        public IReadOnlyCollection<string> Types { get; set; }
    }
}
