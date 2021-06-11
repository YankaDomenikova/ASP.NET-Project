using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStore.Models.ViewModels;

namespace BookStore.Services.Interfaces
{
    interface IGenreService
    {
        List<GenreViewModel> GetAllGenres();

        List<BookViewModel> GetBooksByGenre(string title);
    }
}
