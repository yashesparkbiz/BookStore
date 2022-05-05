namespace BookStore1.Repository
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public class LanguageRepository : ILanguageRepository
=======
    public class LanguageRepository
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
    public class LanguageRepository
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
    public class LanguageRepository
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
    {
        private readonly BookStoreContext _context = null;

        public LanguageRepository(BookStoreContext context)
        {
            _context = context;
        }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
        public async Task<List<Language>> GetLanguages()
        {
            var languages = await _context.Language.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name,
            }).ToListAsync();
        }
    }
}
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
