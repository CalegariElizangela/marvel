using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MarvelAPI.Controllers.DTO;
using MarvelAPI.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarvelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarvelController : Controller
    {
        private readonly ICharacterService _service;

        public MarvelController(ICharacterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ResponseDTO> ObterCoberturas()
        {
            var charactersDto = await _service.GetAllCharacters();
            return new ResponseDTO
            {
                Code = (int)HttpStatusCode.OK,
                Status = HttpStatusCode.OK.ToString(),
                Copyright = "© 2019 MARVEL",
                AttributionText = "Data provided by Marvel. © 2019 MARVEL",
                AttributionHTML = "<a href=\"http://marvel.com\">Data provided by Marvel. © 2019 MARVEL</a>",
                Etag = "b04430e96a52002ce0b73a10c2fcacdaa7a70211",
                Data = new DataDTO
                {
                    Offset = 0,
                    Limit = 20,
                    Total = 1493,
                    Count = charactersDto.Count(),
                    Results = new ResultDTO { Characters = charactersDto }
                }
            };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDTO>> GetOneCharactersAsync(int id)
        {
            var characterDto = await _service.GetOneCharacters(id);
            if (characterDto.Any())
            {
                return new ResponseDTO
                {
                    Code = (int)HttpStatusCode.OK,
                    Status = HttpStatusCode.OK.ToString(),
                    Copyright = "© 2019 MARVEL",
                    AttributionText = "Data provided by Marvel. © 2019 MARVEL",
                    AttributionHTML = "<a href=\"http://marvel.com\">Data provided by Marvel. © 2019 MARVEL</a>",
                    Etag = "b04430e96a52002ce0b73a10c2fcacdaa7a70211",
                    Data = new DataDTO
                    {
                        Offset = 0,
                        Limit = 20,
                        Total = 1,
                        Count = 1,
                        Results = new ResultDTO { Characters = characterDto }
                    }
                };
            }
            else
            {
                return new ResponseDTO
                {
                    Code = (int)HttpStatusCode.NotFound,
                    Status = HttpStatusCode.NotFound.ToString()
                };
            }
        }
    }
}
