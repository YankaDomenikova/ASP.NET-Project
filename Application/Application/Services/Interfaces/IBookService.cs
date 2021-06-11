using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Models.ViewModels;

namespace Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAllBooks();

        BookViewModel GetIndividualBook(string id);
    }
}
