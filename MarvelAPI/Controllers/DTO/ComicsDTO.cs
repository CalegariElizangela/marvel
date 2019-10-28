using Newtonsoft.Json;

namespace MarvelAPI.Controllers.DTO
{
    public class ComicsDTO
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty("items")]
        public ItemDTO Items { get; set; }

        [JsonProperty("returned")]
        public string Returned { get; set; }
    }
}