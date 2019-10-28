using Newtonsoft.Json;

namespace MarvelAPI.Controllers.DTO
{
    public class DataDTO
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public ResultDTO Results { get; set; }
    }
}