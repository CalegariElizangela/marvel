using Newtonsoft.Json;

namespace MarvelAPI.Controllers.DTO
{
    public class ItemDTO
    {
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}