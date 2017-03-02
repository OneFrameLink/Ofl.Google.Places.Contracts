using Newtonsoft.Json;

namespace Ofl.Google.Places
{
    public class LatitudeLongitude
    {
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }

        [JsonProperty("lng")]
        public decimal Longitude { get; set; }
    }
}
