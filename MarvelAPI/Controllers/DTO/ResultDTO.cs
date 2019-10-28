using Newtonsoft.Json;
using System.Collections.Generic;

namespace MarvelAPI.Controllers.DTO
{
    public class ResultDTO
    {
        [JsonProperty("characters")]
        public IList<CharacterDTO> Characters { get; set; }
    }
}