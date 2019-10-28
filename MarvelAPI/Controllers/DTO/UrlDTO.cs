using Newtonsoft.Json;

namespace MarvelAPI.Controllers.DTO
{
    public class UrlDTO
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Value { get; set; }
    }
}