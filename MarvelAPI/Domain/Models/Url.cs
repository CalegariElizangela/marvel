using Newtonsoft.Json;

namespace MarvelAPI.Domain.Models
{
    public class Url
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Value { get; set; }
    }
}