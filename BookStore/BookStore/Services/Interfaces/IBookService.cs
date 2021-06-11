using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Models.ViewModels;

namespace BookStore.Services.Interfaces
{
    interface IBookService
    {
        List<BookViewModel> GetAllBooks();

        BookViewModel GetIndividualBook(string id);
    }
}
