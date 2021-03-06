using BookStore1.Data.Models;
using BookStore1.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookStore1.Data.Repository
{

    public class LanguageRepository : ILanguageRepository

    {
        private readonly BookStoreContext _context = null;

        public LanguageRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguages()
        {
            var Language = await _context.Language.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToListAsync();

            return Language;

        }
    }
}


