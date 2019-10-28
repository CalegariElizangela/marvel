using Newtonsoft.Json;

namespace MarvelAPI.Domain.Models
{
    public class Serie
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        //[JsonProperty("path")]
        //public Item Items { get; set; }

        [JsonProperty("returned")]
        public string Returned { get; set; }
    }
}