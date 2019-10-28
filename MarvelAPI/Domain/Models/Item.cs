using Newtonsoft.Json;

namespace MarvelAPI.Domain.Models
{
    public class Item
    {
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}