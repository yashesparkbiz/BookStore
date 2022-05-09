
using BookStore1.Data.Models;

namespace BookStore1.Data.Repository.Interface
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}