using MarvelAPI.Domain.Models;
using MarvelAPI.Domain.Repositories;
using MarvelAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelAPI.Infrastructure.Repositories
{
    public class CharacterRepository : BaseRepository, ICharacterRepository
    {
        public CharacterRepository(AppDbContext context) : base(context)
        { }

        public async Task<IList<Character>> GetAllCharacters()
        {
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character> GetOneCharacters(int id)
        {
            return await _context.Characters.FindAsync(id);
        }
    }
}