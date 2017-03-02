using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Places
{
    public class Result
    {
        [JsonProperty("address_components")]
        public IReadOnlyCollection<AddressComponent> AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("formatted_phone_number")]
        public string FormattedPhoneNumber { get; set; }

        public Geometry Geometry { get; set; }

        public Uri Icon { get; set; }

        public string Name { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
    }
}
