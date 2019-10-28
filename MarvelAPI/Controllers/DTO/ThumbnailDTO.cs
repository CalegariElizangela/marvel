using Newtonsoft.Json;

namespace MarvelAPI.Controllers.DTO
{
    public class ThumbnailDTO
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}