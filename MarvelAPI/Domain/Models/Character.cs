using Newtonsoft.Json;
using System;

namespace MarvelAPI.Domain.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        //[JsonProperty("thumbnail")]
        //public Thumbnail Thumbnails { get; set; }

        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        //[JsonProperty("comics")]
        //public Comics Comics { get; set; }

        //[JsonProperty("series")]
        //public Serie Series { get; set; }

        //[JsonProperty("stories")]
        //public Storie Stories { get; set; }

        //[JsonProperty("events")]
        //public Event Events { get; set; }

        //[JsonProperty("urls")]
        //public Url Urls { get; set; }
    }
}
