using AutoMapper;
using MarvelAPI.Controllers.DTO;
using MarvelAPI.Domain.Repositories;
using MarvelAPI.Domain.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _repository;

        public CharacterService(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<CharacterDTO>> GetAllCharacters()
        {
            var characters = await _repository.GetAllCharacters();

            var response = new List<CharacterDTO>();

            foreach (var character in characters)
            {
                response.Add(new CharacterDTO
                {
                    Id = character.Id,
                    Name = character.Name,
                    Description = character.Description,
                    Modified = character.Modified,
                    ResourceURI = character.ResourceURI
                });
            }

            return response;
        }

        public async Task<IList<CharacterDTO>> GetOneCharacters(int id)
        {
            var character = await _repository.GetOneCharacters(id);
            if (character != null)
            {
                return new List<CharacterDTO>
                {
                    new CharacterDTO
                    {
                        Id = character.Id,
                        Name = character.Name,
                        Description = character.Description,
                        Modified = character.Modified,
                        ResourceURI = character.ResourceURI
                    }
                };
            }
            else {
                return new List<CharacterDTO>();
            }
        }
    }
}
