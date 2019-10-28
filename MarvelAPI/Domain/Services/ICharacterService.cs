using MarvelAPI.Controllers.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelAPI.Domain.Services
{
    public interface ICharacterService
    {
        Task<IList<CharacterDTO>> GetAllCharacters();
        Task<IList<CharacterDTO>> GetOneCharacters(int id);
    }
}
