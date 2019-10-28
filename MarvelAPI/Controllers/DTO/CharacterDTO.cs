using Newtonsoft.Json;
using System;

namespace MarvelAPI.Controllers.DTO
{
    public class CharacterDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("thumbnail")]
        public ThumbnailDTO Thumbnails { get; set; }

        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("comics")]
        public ComicsDTO Comics { get; set; }

        [JsonProperty("series")]
        public SerieDTO Series { get; set; }

        [JsonProperty("stories")]
        public StorieDTO Stories { get; set; }

        [JsonProperty("events")]
        public EventDTO Events { get; set; }

        [JsonProperty("urls")]
        public UrlDTO Urls { get; set; }
    }
}
