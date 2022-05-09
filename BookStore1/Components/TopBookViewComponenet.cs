
using BookStore1.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Components
{
    [ViewComponent(Name = "TopBook")]
    public class TopBookViewComponenet : ViewComponent
    {
        public readonly IBookRepository _bookRepository;

        public TopBookViewComponenet(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var books = await _bookRepository.GetTopBooksAsync();
            return View(books);
        }
    }
}
