using MarvelAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelAPI.Domain.Repositories
{
    public interface ICharacterRepository
    {
        Task<IList<Character>> GetAllCharacters();
        Task<Character> GetOneCharacters(int id);
    }
}
