namespace Application.Services.Interfaces
{
    using System.Collections.Generic;

    using Application.Models.ViewModels;

    public interface IBookService
    {
        List<BookViewModel> GetAllBooks();

        BookViewModel GetIndividualBook(string id);

        void AddBook(BookViewModel model);
    }
}
